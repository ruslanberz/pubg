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
    public class BlogsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public BlogsController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Control/Blogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Blogs.ToListAsync());
        }

        // GET: Control/Blogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // GET: Control/Blogs/Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateModelBlog model)
        {
            if (ModelState.IsValid) 
            {
                string uniquefilename = null;
                if (model.Photo!=null && model.Photo.Length>0)
                {
                    uniquefilename = ProccedFileUpload(model);                  
                }

                Blog blog = new Blog();
                blog.Title = model.Title;
                blog.Text = model.Text;
                blog.Photo = uniquefilename;
                    
                
                _context.Add(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Control/Blogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            EditModelBlog modelBlog = new EditModelBlog();
            modelBlog.ExistPhotoPath = blog.Photo;
            modelBlog.Text = blog.Text;
            modelBlog.Title = blog.Title;
            return View(modelBlog);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditModelBlog model )
        {
            //if (model.Id != blog.Id)
            //{
            //    return NotFound();
            //}

            if (ModelState.IsValid)
            {
                Blog blog = _context.Blogs.Find(model.Id);
                blog.Text = model.Text;
                blog.Title = model.Title;
                if (model.Photo!=null)
                {
                    if (model.ExistPhotoPath!=null)
                    {
                      string filepath=  Path.Combine(hostingEnvironment.WebRootPath, "images", model.ExistPhotoPath);
                        System.IO.File.Delete(filepath);
                    }
                    blog.Photo = ProccedFileUpload(model);

                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        private string ProccedFileUpload(CreateModelBlog model)
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

        // GET: Control/Blogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // POST: Control/Blogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogExists(int id)
        {
            return _context.Blogs.Any(e => e.Id == id);
        }
    }
}
