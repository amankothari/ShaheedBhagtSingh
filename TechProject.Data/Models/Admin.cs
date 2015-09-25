using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechProject.Data.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }
        [Column(TypeName = "int")]
        public Sex sex { get; set; }
        [Column(TypeName = "nvarchar")]
        public string MobileNumber { get; set; }

        [Column(TypeName = "nvarchar")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar")]
        public string Address { get; set; }
        [Column(TypeName = "varchar")]
        public string City { get; set; }
        [Column(TypeName = "varchar")]
        public string Pincode { get; set; }

    }
}
