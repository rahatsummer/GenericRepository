using LockDownApp.Web.Models.SchoolModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LockDownApp.Web.ViewModels.SchoolViewModel
{
    public class StudentCourseViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Course Name")]
        public int CourseId { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }

    }
}
