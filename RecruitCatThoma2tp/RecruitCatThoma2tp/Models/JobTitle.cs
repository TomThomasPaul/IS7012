using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatThoma2tp.Models
{
    public class JobTitle
    {

        public int JobTitleId { get; set; }
        public string JobTitleName { get; set; }
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public bool FullTimeEmployment { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
