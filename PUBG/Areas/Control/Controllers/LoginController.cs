using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PUBG.Data;
using PUBG.Helper;
using PUBG.Models;

namespace PUBG.Areas.Control.Controllers
{
    [Area("Control")]
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        const string Admin = "_Name";
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Admin admin)
        {
            if (admin!=null)
            {
                var adm = _context.Admins.FirstOrDefault(x => x.Name == admin.Name);
                if (adm!=null)
                {
                    if (Crypto.Verify(admin.Password, adm.Password))
                    {
                        HttpContext.Session.SetInt32(Admin,adm.Id);
                        return RedirectToAction("index", "dashboard");
                    }   
                }
                HttpContext.Session.SetString("ErrMsg", "Email və ya Şifrə səhvdir!");
                return RedirectToAction(nameof(Index));

            }
            HttpContext.Session.SetString("ErrMsg", "Email və ya Şifrə boş olmamalıdır!");
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public  IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction(nameof(Index));
        }
    }
}