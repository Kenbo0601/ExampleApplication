using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApplication.Models.SchoolViewModels
{
    //The Instructor page shows data from three different tables.
    //Thus, we'll create a view model that includes three properties,
    //each holding the data for one of the tables.
    public class InstructorIndexData
    {
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}
