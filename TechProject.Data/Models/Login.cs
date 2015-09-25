using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechProject.Data.Models
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }
        [Column(TypeName = "varchar")]
        public string UserName { get; set; }
        [Column(TypeName = "nvarchar")]
        public string Email { get; set; }
        [Column(TypeName = "bigint")]
        public int Mobile { get; set; }
        [Column(TypeName = "nvarchar")]
        public string Password { get; set; }
        [EnumDataType(typeof(LoginType))]
        public LoginType Type { get; set; }

    }
    public enum LoginType
    {
        Student,
        Admin,
        Staff,
        Faculty
    }
}
