using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfFormAppProject.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; } = string.Empty;
        [Required]
        public string StudentSurname { get; set; } = string.Empty;
        [Required]
        [Length(0, 20)]
        public string StudentNumber { get; set; } = string.Empty;
        public int ClassId { get; set; }
        public Classroom Classroom { get; set; }
        public ICollection<StudentLesson> studentLessons { get; set; } = new List<StudentLesson>();

    }
}
