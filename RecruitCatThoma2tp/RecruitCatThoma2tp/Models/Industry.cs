using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatThoma2tp.Models
{
    public class Industry
    {

        public int IndustryId { get; set; }
        public string IndustryName { get; set; }
        public string IndustryType { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
    }
}
