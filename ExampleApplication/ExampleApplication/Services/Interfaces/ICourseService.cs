using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleApplication.Models;

namespace ExampleApplication.Services.Interfaces
{
    interface ICourseService
    {
        IEnumerable<Course> index();
        IEnumerable<Course> details(int ? id);
        IEnumerable<Course> PopulateDepartmentsDropDownListHelper();
    }
}
