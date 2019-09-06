using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PUBG.Models;
using PUBG.Data;
using Microsoft.AspNetCore.Http;

namespace PUBG.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<LogoutModel> _logger;
        private readonly ApplicationDbContext _context;
        const string SessionName = "_Name";
        public LogoutModel(SignInManager<ApplicationUser> signInManager, ILogger<LogoutModel> logger, ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            string user = HttpContext.Session.GetString(SessionName);
            ApplicationUser current = _context.Users.FirstOrDefault(x => x.UserName == HttpContext.Session.GetString(SessionName));
            current.PreviousLogin = DateTime.UtcNow.AddHours(4);
            _context.SaveChanges();
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
           
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return Page();
            }
        }
    }
}