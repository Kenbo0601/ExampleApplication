using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleApplication.Models
{
    public enum Grade
    {
        A,B,C,D,F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; } //Fireign key
        public int StudentID { get; set; } //foreign key

        //? indicates that the grade property is nullable
        // null means a grade isn't know or hasn't been assigned yet
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; } 
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
