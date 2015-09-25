using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechProject.Data.Models
{
    public class Courses
    {
        [Key]
        public int CourseId { get; set; }
        [Column(TypeName="varchar")]
        [StringLength(100)]
        public string CourseName { get; set; }
        [Column(TypeName = "int")]
        public int Duration { get; set; }
        [Column(TypeName = "int")]
        public int CourseFee { get; set; }
        [Column(TypeName = "int")]
        public int NumberOfsemester { get; set; }
        

    }
}
