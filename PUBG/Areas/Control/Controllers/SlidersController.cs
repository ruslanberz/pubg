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
    public class SlidersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public SlidersController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Control/Sliders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sliders.ToListAsync());
        }

        // GET: Control/Sliders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slider = await _context.Sliders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slider == null)
            {
                return NotFound();
            }

            return View(slider);
        }

        // GET: Control/Sliders/Create
        public IActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateSliderModel model)
        {
            if (ModelState.IsValid)
            {
                string uniquefilename = null;
                if (model.Photo != null && model.Photo.Length > 0)
                {
                    uniquefilename = ProccedFileUpload(model);
                }
                Slider slider = new Slider();
                slider.Photo = uniquefilename;
                slider.Text = model.Text;
                slider.Title = model.Title;
                _context.Add(slider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Control/Sliders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slider = await _context.Sliders.FindAsync(id);
            if (slider == null)
            {
                return NotFound();
            }
            EditSliderModel model = new EditSliderModel();
            model.PhotoPath = slider.Photo;
            model.Id = slider.Id;
            model.Title = slider.Title;
            model.Text = slider.Text;
            return View(model);
        }

        // POST: Control/Sliders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditSliderModel model)
        {
            //if (model.Id != slider.Id)
            //{
            //    return NotFound();
            //}

            if (ModelState.IsValid)
            {
                Slider _slider = _context.Sliders.Find(model.Id);
                _slider.Text = model.Text;
                _slider.Title = model.Title;
                if (model.Photo != null)
                {
                    if (model.PhotoPath != null)
                    {
                        string filepath = Path.Combine(hostingEnvironment.WebRootPath, "images", model.PhotoPath);
                        System.IO.File.Delete(filepath);
                    }
                    _slider.Photo = ProccedFileUpload(model);

                }
                try
                {
                    _context.Update(_slider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SliderExists(_slider.Id))
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
            return View(model);
        }

        // GET: Control/Sliders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slider = await _context.Sliders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slider == null)
            {
                return NotFound();
            }

            return View(slider);
        }

        // POST: Control/Sliders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var slider = await _context.Sliders.FindAsync(id);
            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SliderExists(int id)
        {
            return _context.Sliders.Any(e => e.Id == id);
        }

        private string ProccedFileUpload(CreateSliderModel model)
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
    }
}
