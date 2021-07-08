using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleApplication.Repositories.Interfaces;
using ExampleApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExampleApplication.Data;

namespace ExampleApplication.Repositories
{
    public class CourseRepository : ICourseRepository 
    {
        private readonly SchoolContext _context;

        public CourseRepository(SchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> index()
        {
            var val = _context.Courses.Include(c => c.Department);
            return val.ToList();
        }

        public IEnumerable<Course> details(int ? id)
        {
            IEnumerable<Course> course = _context.Courses.Include(c => c.Department).Where(m => m.CourseID == id);
            return course; //for now
        }

        public IEnumerable<Course> PopulateDepartmentsDropDownListHelper()
        {
            var departmentsQuery = from d in _context.Departments
                                   orderby d.Name
                                   select d;

            return null;
        }
    }
}
