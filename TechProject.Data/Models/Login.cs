﻿using System;
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
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(256)]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar")]
        public string Mobile { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(256)]
        public string Password { get; set; }
        [EnumDataType(typeof(LoginType))]
        public LoginType Type { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Isdeleted { get; set; }
    }
    public enum LoginType
    {
        Admin,
        Staff,
        Faculty
    }
}
