using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LockDownApp.Web.Models.SchoolModels
{
    public class Course
    {
        public int Id { get; set; }

        public string CourseName { get; set; }

        public string CourseCode { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }
    }
}
