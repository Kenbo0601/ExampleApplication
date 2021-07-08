﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExampleApplication.Data;
using ExampleApplication.Models;
using ExampleApplication.Services.Interfaces;

namespace ExampleApplication.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService _courseService;

        //SchoolContext can be used in ASP.NET Core controllers or other 
        //services through constructor injection. 
        //The final result is a SchoolContext instance created for each request and 
        //passed to the controller to perform a unit-of-work before being disposed 
        //when the request ends.
        private readonly SchoolContext _context;

        public CoursesController(ICourseService courseService) 
        {
            _courseService = courseService;
        }

        // GET: Courses
        /*public async Task<IActionResult> Index()
        {
            var schoolContext = _context.Courses.Include(c => c.Department);
            return View(await schoolContext.ToListAsync());
        }*/

        public IActionResult Index()
        {
            return View(_courseService.index());
        }


        // GET: Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            //--- eager loading method ---//

            //LINQ Method syntax
            var course = await _context.Courses
                .Include(c => c.Department)
                .AsNoTracking() //read only scenario. if you don't need to update a database, this is quicker
                .Where(m => m.CourseID == id)
                .FirstOrDefaultAsync(); //.FirstOrDefaultAsync(m => m.CourseID == id); 

            //LINQ Query syntax
            var course2 = await (from s in _context.Courses.Include(c => c.Department)
                                 where s.CourseID == id
                                 //orderby s.Title descending
                                 select s).
                                 FirstOrDefaultAsync();
            
            //IEnumeable is better for in-memory collection or local queries
            //Filter logic is executed on client's side
            IEnumerable<Course> course3 = _context.Courses.Include(c => c.Department).Where(m => m.CourseID == id);
            //IQueryable is better for remote database 
            //Filter logic is executed on server side (or remote database) 
            IQueryable<Course> course4 = _context.Courses.Include(c => c.Department).Where(m => m.CourseID == id);

            Console.Write(course2);

            if (course2 == null)
            {
                return NotFound();
            }

            var result = _courseService.details(id); //involking the service/repository method 

            //return View(course4.FirstOrDefault());
            return View(result);
        }

        // GET: Courses/Create
        public IActionResult Create()
        {
            //ViewData["DepartmentID"] = new SelectList(_context.Departments, "DepartmentID", "DepartmentID");
            PopulateDepartmentsDropDownList();
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseID,Title,Credits,DepartmentID")] Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["DepartmentID"] = new SelectList(_context.Departments, "DepartmentID", "DepartmentID", course.DepartmentID);
            PopulateDepartmentsDropDownList(course.DepartmentID);
            return View(course);
        }
        
        // GET: Courses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.CourseID == id);
            if (course == null)
            {
                return NotFound();
            }
            //ViewData["DepartmentID"] = new SelectList(_context.Departments, "DepartmentID", "DepartmentID", course.DepartmentID);
            PopulateDepartmentsDropDownList(course.DepartmentID);
            return View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseToUpdate = await _context.Courses
                .FirstOrDefaultAsync(c => c.CourseID == id);

            if (await TryUpdateModelAsync<Course>(courseToUpdate,
                "",
                c => c.Credits, c => c.DepartmentID, c => c.Title))
            {
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
                return RedirectToAction(nameof(Index));
            }
            PopulateDepartmentsDropDownList(courseToUpdate.DepartmentID);
            return View(courseToUpdate);
        }

        private void PopulateDepartmentsDropDownListHelper()
        {
            return;
        }
        private void PopulateDepartmentsDropDownList(object selectedDepartment = null)
        {
            var departmentsQuery = from d in _context.Departments
                                   orderby d.Name
                                   select d;
            ViewBag.DepartmentID = new SelectList(departmentsQuery.AsNoTracking(), "DepartmentID", "Name", selectedDepartment);
        }

        // GET: Courses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.Department)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.CourseID == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.CourseID == id);
        }
    }
}
