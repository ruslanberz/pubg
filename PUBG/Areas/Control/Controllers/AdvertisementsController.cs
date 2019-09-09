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
    public class AdvertisementsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public AdvertisementsController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Control/Advertisements
        public async Task<IActionResult> Index()
        {
            return View(await _context.Advertisements.OrderByDescending(x=>x.Id).ToListAsync());
        }

        // GET: Control/Advertisements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            } // bax bele bir reklam struktur qurdum, senin fikrivi eshitmek isterdim

            var advertisement = await _context.Advertisements
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advertisement == null)
            {
                return NotFound();
            }

            return View(advertisement);
        }

        // GET: Control/Advertisements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/Advertisements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(createAdsModel advertisement )
        {
            if (ModelState.IsValid)
            {
                string uniquefilename = null;
                if (advertisement.Image != null && advertisement.Image.Length > 0)
                {
                    uniquefilename = ProccedFileUpload(advertisement);
                }

                Advertisement ads = new Advertisement();
                
                ads.UniqueID = "#"+RandomString(6);
                ads.Title = advertisement.Title + " "+ads.UniqueID;
                ads.BodyText = advertisement.BodyText;
                ads.CreationDate = DateTime.UtcNow.AddHours(4);
                ads.ValidUntil = advertisement.ValidUntil;
                ads.Image = uniquefilename;
                
                _context.Add(ads);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(advertisement);
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        // GET: Control/Advertisements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advertisement = await _context.Advertisements.FindAsync(id);
            if (advertisement == null)
            {
                return NotFound();
            }
            EditAdsModel forview = new EditAdsModel();
            forview.Title = advertisement.Title;
            forview.UniqueID = advertisement.UniqueID;
            forview.CreationDate = advertisement.CreationDate;
            forview.ValidUntil = advertisement.ValidUntil;
            forview.BodyText = advertisement.BodyText;
            forview.PhotoPath = advertisement.Image;
            forview.Id = advertisement.Id;
            return View(forview);
        }

        // POST: Control/Advertisements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditAdsModel edit)
        {
            //if (id != advertisement.Id)
            //{
            //    return NotFound();
            //}

            if (ModelState.IsValid)
            {
                Advertisement ad = _context.Advertisements.Find(edit.Id);
                ad.Title = edit.Title;
                ad.BodyText = edit.BodyText;
                ad.ValidUntil = edit.ValidUntil;
                ad.UniqueID = edit.UniqueID;
                ad.CreationDate = edit.CreationDate;
                if (edit.Image != null)
                {
                    if (edit.PhotoPath != null)
                    {
                        string filepath = Path.Combine(hostingEnvironment.WebRootPath, "images", edit.PhotoPath);
                        System.IO.File.Delete(filepath);
                    }
                    ad.Image = ProccedFileUpload(edit);

                }

                try
                {
                    _context.Update(ad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvertisementExists(edit.Id))
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
            return View(edit);
        }

        private string ProccedFileUpload(createAdsModel model)
        {
            string uniquefilename = null;
            if (model.Image != null && model.Image.Length > 0)
            {
                var uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniquefilename = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
                string filePath = Path.Combine(uploadFolder, uniquefilename);
                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    model.Image.CopyTo(filestream);

                }


            }
            return uniquefilename;
        }


        // GET: Control/Advertisements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advertisement = await _context.Advertisements
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advertisement == null)
            {
                return NotFound();
            }

            return View(advertisement);
        }

        // POST: Control/Advertisements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var advertisement = await _context.Advertisements.FindAsync(id);
            _context.Advertisements.Remove(advertisement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvertisementExists(int id)
        {
            return _context.Advertisements.Any(e => e.Id == id);
        }
    }
}
