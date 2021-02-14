using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatThoma2tp.Models
{
    public class JobTitle
    {

        public int JobTitleId { get; set; }

        [StringLength(25)]
        [Required(ErrorMessage = "Job Title Name is required")]
        [DisplayName("Job Title Name")]
        public string JobTitleName { get; set; }

        [Range(1000,200000)]
        [Required(ErrorMessage = "Minimum Salary is required")]
        [DisplayName("Minimum Salary")]
        public decimal MinimumSalary { get; set; }

        [Range(1000, 200000)]
        [Required(ErrorMessage = "Maximum Salary is required")]
        [DisplayName("Maximum Salary")]
        public decimal MaximumSalary { get; set; }

        [DisplayName("Full Time Employment")]
        public bool FullTimeEmployment { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
