using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
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
    public class GalleryPhotosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public GalleryPhotosController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Control/GalleryPhotos
        public async Task<IActionResult> Index()
        {
            return View(await _context.GalleryPhotos.ToListAsync());
        }

        // GET: Control/GalleryPhotos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galleryPhotos = await _context.GalleryPhotos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (galleryPhotos == null)
            {
                return NotFound();
            }

            return View(galleryPhotos);
        }

        // GET: Control/GalleryPhotos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/GalleryPhotos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateGalleryPhoto model)
        {
            if (ModelState.IsValid)
            {
                string uniquefilename = null;
                if (model.Photo != null && model.Photo.Length > 0)
                {
                    uniquefilename = ProccedFileUpload(model);
                }

                GalleryPhotos photo = new GalleryPhotos();
                photo.Image = uniquefilename;


                _context.Add(photo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Control/GalleryPhotos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galleryPhotos = await _context.GalleryPhotos.FindAsync(id);
            if (galleryPhotos == null)
            {
                return NotFound();
            }
            EditGalleryPhoto modelGallery = new EditGalleryPhoto();
            modelGallery.ExistPhotoPath = galleryPhotos.Image;
           
            return View(modelGallery);
        }

        // POST: Control/GalleryPhotos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit( EditGalleryPhoto model )
        {
            if (ModelState.IsValid)
            {
                GalleryPhotos gphoto = _context.GalleryPhotos.Find(model.Id);
                
                if (model.Photo != null)
                {
                    if (model.ExistPhotoPath != null)
                    {
                        string filepath = Path.Combine(hostingEnvironment.WebRootPath, "images", model.ExistPhotoPath);
                        System.IO.File.Delete(filepath);
                    }
                    gphoto.Image = ProccedFileUpload(model);

                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Control/GalleryPhotos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galleryPhotos = await _context.GalleryPhotos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (galleryPhotos == null)
            {
                return NotFound();
            }

            return View(galleryPhotos);
        }

        // POST: Control/GalleryPhotos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var galleryPhotos = await _context.GalleryPhotos.FindAsync(id);
            _context.GalleryPhotos.Remove(galleryPhotos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private string ProccedFileUpload(CreateGalleryPhoto model)
        {
            string uniquefilename = null;
            if (model.Photo != null && model.Photo.Length > 0)
            {
                var uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniquefilename = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadFolder, uniquefilename);
                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(filestream);

                }


            }
            return uniquefilename;
        }
        private bool GalleryPhotosExists(int id)
        {
            return _context.GalleryPhotos.Any(e => e.Id == id);
        }
    }
}
