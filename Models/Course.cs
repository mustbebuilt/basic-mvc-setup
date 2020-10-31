using System;
using System.ComponentModel.DataAnnotations;

namespace BasicMVCDemo.Models
{
    public class Course

    {
        [Key]
        public int Id { get; set; }

        public string CourseLevel { get; set; }

        public string CourseName { get; set; }
    }

}
