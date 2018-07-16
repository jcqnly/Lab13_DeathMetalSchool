using CradleOfFilth.Data;
using CradleOfFilth.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CradleOfFilth.Controllers
{
    public class CourseController : Controller
    {
        private MetalDbContext _context;

        public CourseController(MetalDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Course> courses = _context.Courses.ToList();
            CourseViewModel cvm = new CourseViewModel()
            {
                Courses = courses
            };
            return View(cvm);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var foundCourse = await _context.Courses.FindAsync(id);
            return View(foundCourse);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID, Name, Description")] Course course)
        {
            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID, Name, Description")] Course course)
        {
            if (id != course.ID)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(course);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(course);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var foundCourse = _context.Courses.FirstOrDefault(c => c.ID == id);
            _context.Courses.Remove(foundCourse);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
