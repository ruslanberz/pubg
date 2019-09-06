using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PUBG.Areas.Control.Models;
using PUBG.Data;
using PUBG.Helper;
using PUBG.Models;

namespace PUBG.Areas.Control.Controllers
{
    
    [Area("Control")]
    [ServiceFilter(typeof(Auth))]
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public DashboardController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            var currentSeason = _context.Seasons.FirstOrDefault(x => x.IsActive == true);
            var model = _context.Users.Where(x => !x.SkippedUsers.Any(y => y.ApplicationUserId.Contains(y.ApplicationUserId))).Select(x=>new DashboardIndex {
                Points=_context.Posteds.Where(z=>z.SeasonId==currentSeason.Id).Sum(c=>c.Point),
                PubgUsername=x.PubgUsername,
                Count= _context.Posteds.Where(z => z.ApplicationUserId == x.Id && z.SeasonId == currentSeason.Id).Count(),

                Id=x.Id

        }).OrderByDescending(t=>t.Count).ToList();
            

            return View(model);
        }

       
        public IActionResult Result(string id)
        {
            SkippedUser skip = new SkippedUser();
            skip.ApplicationUserId = id;
            skip.SeasonId = _context.Seasons.FirstOrDefault(x => x.IsActive == true).Id;
            _context.SkippedUsers.Add(skip);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}