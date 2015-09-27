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
        [StringLength(100)]
        public string FirstName { get; set; }
        [EnumDataType(typeof(Sex))]
        public Sex sex { get; set; }
        [Column(TypeName = "bigint")]
        public int MobileNumber { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(256)]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(256)]
        public string Address { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string City { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Pincode { get; set; }

    }
}
