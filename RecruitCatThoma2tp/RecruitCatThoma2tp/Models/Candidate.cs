using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatThoma2tp.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(15)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(15)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Target Salary is required")]
        [Range(1000,200000)]
        [DisplayName("Target Salary")]
        public decimal TargetSalary { get; set; }

        [Required(ErrorMessage = "Candidate Start Date is required")]
        [DataType(DataType.Date)]
        [DisplayName("Candidate Start Date")]
        public DateTime? CandidateStartDate { get; set; }

        [StringLength(50)]
        [DisplayName("Current Organization Name")]
        public string CurrentOrganizationName { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        public List<Contact> ContactDetails { get; set; }
        public Company Company { get; set; }

        [Required(ErrorMessage = "Company Name is required")]
        [DisplayName("Company Name")]
        public int? CompanyId { get; set; }
        public JobTitle JobTitle { get; set; }

        [Required(ErrorMessage = "Job Title is required")]
        [DisplayName("Job Title")]
        public int JobTitleId { get; set; }
        public Industry Industry { get; set; }

        [Required(ErrorMessage = "Industry Name is required")]
        [DisplayName("Industry Name")]
        public int IndustryId { get; set; }

        [StringLength(30)]
        [DisplayName("Full Name")]
        public string FullName
        {

            get
            {

                return $"{FirstName} {LastName}";
            }
        }
    }
}
