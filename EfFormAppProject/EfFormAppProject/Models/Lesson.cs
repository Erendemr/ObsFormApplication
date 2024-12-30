using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfFormAppProject.Models
{
    public class Lesson
    {
        public int LessonId { get; set; }
        [Required]
        public int LessonCode { get; set; }
        [Required]
        public string LessonName { get; set; } = string.Empty;
        public ICollection<StudentLesson> StudentLessons { get; set; } = new List<StudentLesson>();
    }
}
