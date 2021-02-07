using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatThoma2tp.Models
{
    public class Company
    {

        public int CompanyId { get; set; }
        public string PositionName { get; set; }
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public DateTime? ProposedStartDate { get; set; }
        public List<Contact> ContactDetails { get; set; }
        public List<Candidate> Candidates { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public decimal? AnnualTurnOver { get; set; }
    }
}
