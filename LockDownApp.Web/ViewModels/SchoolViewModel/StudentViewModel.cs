using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LockDownApp.Web.ViewModels.SchoolViewModel
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required]
        [Display(Name = "Contact Info")]
        public string ContactNo { get; set; }
    }
}
