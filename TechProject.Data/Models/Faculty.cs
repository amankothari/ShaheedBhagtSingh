using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechProject.Data.Models
{
   public class Faculty 
    {
        [Key]
        public int FacultyId { get; set; }

        [MaxLength(50)]
        [StringLength(100)]
        [Display(Name = "Employee ID")]
        public string EmployeeID { get; set; }

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

        [MaxLength(1000)]
        [StringLength(1000)]
        public string Address { get; set; }
        [MaxLength(100)]
        [StringLength(100)]
        public string City { get; set; }
        [MaxLength(100)]
        [StringLength(100)]
        public string PostalCode { get; set; }
        [MaxLength(100)]
        [StringLength(100)]
        public string State { get; set; }

        [MaxLength(1000)]
        [StringLength(1000)]
        public string PermanentAddress { get; set; }
        [MaxLength(100)]
        [StringLength(100)]
        public string PermanentCity { get; set; }
        [MaxLength(100)]
        [StringLength(100)]
        public string PermanentPostalCode { get; set; }
        [MaxLength(100)]
        [StringLength(100)]
        public string PermanentState { get; set; }
        [MaxLength(100)]
        [StringLength(100)]
        public string Country { get; set; }
        public string PhotoURL { get; set; }
        [MaxLength(100)]
        [StringLength(100)]
        public string PersonalContact { get; set; }

        public string Email { get; set; }
        [MaxLength(100)]
        [StringLength(100)]
        public string HomeContact { get; set; }
        
        public string EducationType { get; set; }
        public string Education { get; set; }
        public string JobType { get; set; }
        public Department Department { get; set; }
        public string Designation { get; set; }
        public string JoiningDate { get; set; }



        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool Isdeleted { get; set; }
    }
}
