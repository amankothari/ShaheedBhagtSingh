using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechProject.Data.Models
{
    public class StudentQuery
    {
        [Key]
        public int QueryId { get; set; }
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }
        [EnumDataType(typeof(Category))]
        public Category Category { get; set; }

        [EnumDataType(typeof(Sex))]
        public Sex Gender { get; set; }
        [Column(TypeName = "bigint")]
        public int MobileNumber { get; set; }
        [Column(TypeName = "nvarchar")]
        public string Email { get; set; }
        [Column(TypeName = "varchar")]
        public string City { get; set; }
        [Column(TypeName = "varchar")]
        public string Pincode { get; set; }
        public Courses Course { get; set; }
        [Column(TypeName = "int")]
        public int PassoutYear10th { get; set; }
        [Column(TypeName = "int")]
        public int Percentage10th { get; set; }
        [Column(TypeName = "varchar")]
        public string SchoolName10th { get; set; }
        [Column(TypeName = "int")]
        public int PassoutYear12th { get; set; }
        [Column(TypeName = "int")]
        public int Percentage12th { get; set; }
        [Column(TypeName = "varchar")]
        public string SchoolName12th { get; set; }


        public string Interest { get; set; }

    }

    public enum Sex
    {
        Male,
        Female
    }
    public enum Category
    {
        General,
        OBC,
        ST,
        SC
    }

}
