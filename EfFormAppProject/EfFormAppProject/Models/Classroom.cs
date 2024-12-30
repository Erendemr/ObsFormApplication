using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfFormAppProject.Models
{
    public class Classroom
    {
        public int ClassId { get; set; }
        [Required]
        public string ClassName { get; set; } = string.Empty;
        public int Quota { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
