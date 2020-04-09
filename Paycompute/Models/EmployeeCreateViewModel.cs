using Microsoft.AspNetCore.Http;
using Paycompute.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Paycompute.Models
{
    public class EmployeeCreateViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Employee Number is required")]
        [RegularExpression(@"^[A-Z]{3,3}[0-9]{3}$")]
        public string EmployeeNo { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [Display(Name = "First Name")]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A][a-zA-Z""'\s-]*$")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [Display(Name = "Last Name")]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A][a-zA-Z""'\s-]*$")]
        public string LastName { get; set; }

        [StringLength(50)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        public string FullName {
            get
            {
                return FirstName + (string.IsNullOrEmpty(MiddleName) ? " " : 
                    (" " + (char?)MiddleName[0]) + ". ").ToUpper() + LastName;
            }
        }

        public string Gender { get; set; }

        [Display(Name = "Photo")]
        public IFormFile ImageUrl { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Joined")]
        public DateTime DateJoined { get; set; } = DateTime.UtcNow;

        [Required(ErrorMessage = "Job Role is required")]
        [StringLength(100)]
        public string Designation { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Phone { get; set; }

        [Required(ErrorMessage = "National Insurance Number is required")]
        [StringLength(50)]
        [Display(Name = "NI No.")]
        [RegularExpression(@"^[A-CEGHJ-PR-TW-Z]{1} [A-CEGHJ-NPR-TW-Z]{1} [0-9]{6} [A-D\s]$")]
        //SSN  @"^\d{3}-\d{2}-\d{4}$"
        public string NationalInsuranceNo { get; set; }

        [Display(Name = "Payment Method")]
        public PaymentMethod PaymentMethod { get; set; }

        [Display(Name = "Student Loand")]
        public StudentLoan StudentLoan { get; set; }

        [Display(Name = "Union Member")]
        public UnionMember UnionMember { get; set; }

        [Required]
        [StringLength(150)]
        public string Address { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string PostCode { get; set; }
        public IEnumerable<PaymentRecord> PaymentRecords { get; set; }
    }
}
