using System;
using System.ComponentModel.DataAnnotations;

namespace <YOUR-PROJECT-NAME>.Models
{
    public class Course

    {
        [Key]
        public int Id { get; set; }

        public string CourseLevel { get; set; }

        public string CourseName { get; set; }
    }

}
