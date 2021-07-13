using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleApplication.Repositories.Interfaces;
using ExampleApplication.Models;
using ExampleApplication.Data;
using Microsoft.EntityFrameworkCore;

namespace ExampleApplication.Repositories
{
    public class testRepository : ItestRepository
    {
        private readonly SchoolContext _context;

        public testRepository(SchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> getData()
        {
            var val = _context.Courses.Include(c => c.Department);
            return val.ToList();
        }
    }
}
