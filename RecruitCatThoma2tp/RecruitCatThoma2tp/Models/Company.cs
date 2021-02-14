using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatThoma2tp.Models
{
    public class Company
    {

        public int CompanyId { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Company Name is required")]
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Position Name is required")]
        [DisplayName("Position Name")]
        public string PositionName { get; set; }

        [Range(1000,200000)]
        [Required(ErrorMessage = "Minimum Salary is required")]
        [DisplayName("Minimum Salary")]
        public decimal MinimumSalary { get; set; }

        [Range(1000, 200000)]
        [Required(ErrorMessage = "Maximum Salary is required")]
        [DisplayName("Maximum Salary")]
        public decimal MaximumSalary { get; set; }

        [Required(ErrorMessage = "Proposed Start Date required")]
        [DataType(DataType.Date)]
        [DisplayName("Proposed Start Date")]
        public DateTime? ProposedStartDate { get; set; }
        public List<Contact> ContactDetails { get; set; }
        public List<Candidate> Candidates { get; set; }
        public Industry Industry { get; set; }

        [Required(ErrorMessage = "Industry Name is required")]
        [DisplayName("Industry Type")]
        public int IndustryId { get; set; }

        [Range(1000, 20000000)]
        [Required(ErrorMessage = "Annual Turnover is required")]
        [DisplayName("Annual Turnover")]
        public decimal? AnnualTurnOver { get; set; }
    }
}
