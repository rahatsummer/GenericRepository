﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LockDownApp.Web.Models.SchoolModels
{
    public class StudentCourse
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }
    }
}
