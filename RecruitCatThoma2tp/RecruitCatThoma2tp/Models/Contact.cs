using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatThoma2tp.Models
{
    public class Contact
    {

        public int ContactId { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string ContactType { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
        public Candidate Candidate { get; set; }
        public int CandidateId { get; set; }
    }
}
