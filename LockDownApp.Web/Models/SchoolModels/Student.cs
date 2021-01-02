using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LockDownApp.Web.Models.SchoolModels
{
    public class Student
    {
        public int Id { get; set; }

        public string StudentName { get; set; }

        public string ContactNo { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }
    }
}
