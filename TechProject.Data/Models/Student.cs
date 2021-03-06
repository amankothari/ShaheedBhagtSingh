﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechProject.Data.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [MaxLength(50)]
        [StringLength(100)]
        [Display(Name = "Applicant ID")]
        public string ApplicantID { get; set; }

        [MaxLength(50)]
        [StringLength(100)]
        [Display(Name = "FullName")]
        public string Name { get; set; }


        [Display(Name = "Date Of Birth")]
        public string DOB { get; set; }
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S/O")]
        public string SO { get; set; }
        [Display(Name = "Gender")]
        [EnumDataType(typeof(Sex))]
        public Sex Gender { get; set; }
        [Display(Name = "Category")]
        [EnumDataType(typeof(Category))]
        public Category Category { get; set; }
        [Display(Name = "Admission year")]
        public string AdYear { get; set; }
        [Display(Name = "Course")]
        public Courses Course { get; set; }

        public string cert10thURL { get;set;}
        public string cert12thURL { get; set; }
        public string domicilecertURL { get; set; }
        public string aadharcertURL { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
      

        
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string Newpassword { get; set; }

       
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Newpassword")]
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string ConfirmNewpassword { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool Isdeleted { get; set; }
    }
}
