using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleApplication.Services.Interfaces;
using ExampleApplication.Repositories.Interfaces;
using ExampleApplication.Models;

namespace ExampleApplication.Services
{
    public class CourseService : ICourseService 
    {
        private readonly ICourseRepository _courseRepo;

        public CourseService(ICourseRepository courseRepo)
        {
            _courseRepo = courseRepo;
        }

        public IEnumerable<Course> index() => _courseRepo.index();
        public IEnumerable<Course> details(int? id) => _courseRepo.details(id);
        IEnumerable<Course> PopulateDepartmentsDropDownListHelper()
        {
            return _courseRepo.PopulateDepartmentsDropDownListHelper();
        }
    }
}
