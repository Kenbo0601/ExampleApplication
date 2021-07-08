using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleApplication.Models;

namespace ExampleApplication.Repositories.Interfaces
{
    interface ICourseRepository
    {
        IEnumerable<Course> index();
        IEnumerable<Course> details(int? id);
        IEnumerable<Course> PopulateDepartmentsDropDownListHelper();
    }
}
