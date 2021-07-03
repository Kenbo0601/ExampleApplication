using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleApplication.Models
{
    public class Student
    {
        public int ID { get; set; }
        
        [Required] //must be used with MinimumLength 
        [StringLength(50, MinimumLength =2)]
        [Display(Name ="Last Name")] //specifies the caption for the text boxes
        public string LastName { get; set; }

        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
