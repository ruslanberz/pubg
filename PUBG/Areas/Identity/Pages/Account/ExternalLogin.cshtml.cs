using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PUBG.Data;
using PUBG.Models;
namespace PUBG.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ExternalLoginModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<ExternalLoginModel> _logger;
        private readonly ApplicationDbContext _context;

        public ExternalLoginModel(
            SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager,
            ILogger<ExternalLoginModel> logger,
            ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
            _context = context;
        }
        

       

        [BindProperty]
        public InputModel Input { get; set; }

        public string LoginProvider { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Email boş buraxmayın!")]
            
            [EmailAddress(ErrorMessage ="Düzgün bir email daxil edin!")]
            public string Email { get; set; }
            [Required(ErrorMessage = "Ad və Soyadınızı boş buraxmayın!")]
            public string Name { get; set; }
            //public DateTime Create { get; set; }
            [Required(ErrorMessage = "PUBG nickinizi boş buraxmayın")]

            public string PubgUsername { get; set; }
        }

        public IActionResult OnGetAsync()
        {
            return RedirectToPage("./Login");
        }

        public IActionResult OnPost(string provider, string returnUrl = null)
        {
            // Request a redirect to the external login provider.
            var redirectUrl = Url.Page("./ExternalLogin", pageHandler: "Callback", values: new { returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return new ChallengeResult(provider, properties);
        }

        public async Task<IActionResult> OnGetCallbackAsync(string returnUrl = null, string remoteError = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (remoteError != null)
            {
                ErrorMessage = $"Error from external provider: {remoteError}";
                return RedirectToPage("./Login", new {ReturnUrl = returnUrl });
            }
            var info = await _signInManager.GetExternalLoginInfoAsync();//info null gelende yeni useri tapmayanda registra gonderir
            if (info == null)
            {
                ErrorMessage = "Error loading external login information.";
                return RedirectToPage("./Login", new { ReturnUrl = returnUrl });
            }
            
            // Sign in the user with this external login provider if the user already has a login.
            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor : true);
            if (result.Succeeded)//burda user i tapir ana sehifeye gonderir
            {
                _logger.LogInformation("{Name} logged in with {LoginProvider} provider.", info.Principal.Identity.Name, info.LoginProvider);
                //bes register olandada bura gelir? registereddirse - bura ishleyir yeni istif dirse-
                //burda db instance alib last ve prev loginleri deyishmeliyik

                return LocalRedirect("/home/cabinet"); //burda 1 getmiyecek

            }
            if (result.IsLockedOut)
            {
                return RedirectToPage("./Lockout");
            }
            else
            {
                // If the user does not have an account, then ask the user to create an account. bura ishleyir
                ReturnUrl = returnUrl;
                LoginProvider = info.LoginProvider;
                if (info.Principal.HasClaim(c => c.Type == ClaimTypes.Email))
                {
                    Input = new InputModel
                    {
                        Email = info.Principal.FindFirstValue(ClaimTypes.Email)
                    };
                }
                if (info.Principal.HasClaim(c => c.Type == ClaimTypes.Name))
                {
                    Input = new InputModel
                    {
                        Name = info.Principal.FindFirstValue(ClaimTypes.Name)
                    };
                }
                //ApplicationUser current = _context.Users.FirstOrDefault(x => x.UserName == info.Principal.Identity.Name);
                //current.LastLogin = DateTime.UtcNow.AddHours(4);
                //_context.SaveChanges();
               
                //regitr olanda da login tarixi burda yazacagiq - yox registerconfirmde
                //bunu men custom yazmisham registra gonderir, he emailvar idi name ona  baxib yazdim
                return Page();
            }
        }

        public async Task<IActionResult> OnPostConfirmationAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            // Get the information about the user from the external login provider
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                ErrorMessage = "Error loading external login information during confirmation.";
                return RedirectToPage("./Login", new { ReturnUrl = returnUrl });
            }

            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = Input.Email, Email = Input.Email, Fullname = Input.Name, CreationDate = DateTime.UtcNow.AddHours(4), PreviousLogin=DateTime.UtcNow.AddHours(4),LastLogin=DateTime.UtcNow.AddHours(4),PubgUsername=Input.PubgUsername };//burda  user her hansisa bir kod yazib onu vereceyik unik
                var result = await _userManager.CreateAsync(user);//burda elave edir
                if (result.Succeeded)
                {
                    result = await _userManager.AddLoginAsync(user, info);
                    if (result.Succeeded)
                    {
                        
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        _logger.LogInformation("User created an account using {Name} provider.", info.LoginProvider);
                        return LocalRedirect("/home/cabinet"); //bura 2 islemiyecek
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            LoginProvider = info.LoginProvider;
            ReturnUrl = returnUrl;
            return Page();
        }
    }
}
