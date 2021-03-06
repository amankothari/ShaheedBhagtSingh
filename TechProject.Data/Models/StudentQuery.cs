﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [StringLength(100)]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string LastName { get; set; }
        [EnumDataType(typeof(Category))]
        public Category Category { get; set; }

        [EnumDataType(typeof(Sex))]
        public Sex Gender { get; set; }
        [Column(TypeName = "nvarchar")]

        public string MobileNumber { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(256)]
        public string Email { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string City { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Pincode { get; set; }
       
        public Courses Course { get; set; }
        [Column(TypeName = "int")]
        public int PassoutYear10th { get; set; }
        [Column(TypeName = "int")]
        public int Percentage10th { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string SchoolName10th { get; set; }
        [Column(TypeName = "int")]
        public int PassoutYear12th { get; set; }
        [Column(TypeName = "int")]
        public int Percentage12th { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string SchoolName12th { get; set; }
        [StringLength(100)]
        public string Stream { get; set; }


        public string Interest { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Isdeleted { get; set; }

    }

    public enum Sex
    {
        Male,
        Female
    }
    public enum Category
    {
        UR,
        OBC,
        ST,
        SC
    }
   
}
