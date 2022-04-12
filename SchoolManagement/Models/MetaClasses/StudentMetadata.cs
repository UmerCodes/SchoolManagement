using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolManagement.Models
{
    public class StudentMetadata
    {
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        //[StringLength(50)]
        //[Display(Name = "Middle Name")]
        //public string MiddleName { get; set; }

        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date Of Enrollment")]
        public Nullable<System.DateTime> EnrollmentDate { get; set; }
        
    }

    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {

    }
}