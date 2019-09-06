using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PUBG.Areas.Control.Models;
using PUBG.Data;
using PUBG.Helper;
using PUBG.Models;

namespace PUBG.Areas.Control.Controllers
{
    [Area("Control")]
    [ServiceFilter(typeof(Auth))]
    public class PostedsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;


        public PostedsController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Control/Posteds
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Posteds.Include(p => p.ApplicationUser).ThenInclude(x=>x.SkippedUsers).Include(p => p.Season);
            return View(await applicationDbContext.ToListAsync()); 
        }

        // GET: Control/Posteds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posted = await _context.Posteds
                .Include(p => p.ApplicationUser)
                .Include(p => p.Season)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (posted == null)
            {
                return NotFound();
            }

            return View(posted);
        }

        // GET: Control/Posteds/Create
        public IActionResult Create()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["SeasonId"] = new SelectList(_context.Seasons, "Id", "Id");
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreatePostModel model)
        {
            if (ModelState.IsValid)
            {
                string uniquefilename = null;
                if (model.ImagePath != null && model.ImagePath.Length > 0)
                {
                    uniquefilename = ProccedFileUpload(model);
                }

                Posted posted = new Posted();
                posted.Point = model.Point;
                posted.SeasonId = model.SeasonId;
                posted.ImagePath = uniquefilename;
                posted.ApplicationUserId = model.ApplicationUserId;
                posted.CreatedAt = model.CreatedAt;

                _context.Add(posted);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id", model.ApplicationUserId);
            ViewData["SeasonId"] = new SelectList(_context.Seasons, "Id", "Id", model.SeasonId);
            return View(model);
        }

        // GET: Control/Posteds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posted = await _context.Posteds.FindAsync(id);
            if (posted == null)
            {
                return NotFound();
            }

            EditPostModel model = new EditPostModel();
            model.ApplicationUserId = posted.ApplicationUserId;
            model.CreatedAt = posted.CreatedAt;
            model.Id = posted.Id;
            model.ExistPhotoPath = posted.ImagePath;
            model.Point = posted.Point;
            model.SeasonId = posted.SeasonId;

            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id", model.ApplicationUserId);
            ViewData["SeasonId"] = new SelectList(_context.Seasons, "Id", "Id", model.SeasonId);
            return View(model);
        }

        // POST: Control/Posteds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditPostModel model)
        {
            //if (id != posted.Id)
            //{
            //    return NotFound();
            //}
            Posted posted = _context.Posteds.Find(model.Id);
            if (ModelState.IsValid && posted!=null)
            {
                
                posted.Point = model.Point;
                posted.CreatedAt = model.CreatedAt;
                posted.ApplicationUserId = model.ApplicationUserId;
                posted.SeasonId = model.SeasonId;
                if (model.ImagePath!=null && model.ImagePath.Length>0)
                {
                    //if (model.ExistPhotoPath != null)
                    //{
                    //    string filepath = Path.Combine(hostingEnvironment.WebRootPath, "images", model.ExistPhotoPath);
                    //    System.IO.File.Delete(filepath);
                    //}
                    posted.ImagePath = ProccedFileUpload(model);
                }

                try
                {
                    _context.Update(posted);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostedExists(posted.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id", posted.ApplicationUserId);
            ViewData["SeasonId"] = new SelectList(_context.Seasons, "Id", "Id", posted.SeasonId);
            return View(model);
        }

        // GET: Control/Posteds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posted = await _context.Posteds
                .Include(p => p.ApplicationUser)
                .Include(p => p.Season)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (posted == null)
            {
                return NotFound();
            }

            return View(posted);
        }

        // POST: Control/Posteds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var posted = await _context.Posteds.FindAsync(id);
            _context.Posteds.Remove(posted);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostedExists(int id)
        {
            return _context.Posteds.Any(e => e.Id == id);
        }
        private string ProccedFileUpload(CreatePostModel model)
        {
            string uniquefilename = null;
            if (model.ImagePath != null && model.ImagePath.Length > 0)
            {
                var uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniquefilename = Guid.NewGuid().ToString() + "_" + model.ImagePath.FileName;
                string filePath = Path.Combine(uploadFolder, uniquefilename);
                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImagePath.CopyTo(filestream);

                }


            }
            return uniquefilename;
        }
    }
}
