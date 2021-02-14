using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatThoma2tp.Models
{
    public class Contact
    {

        public int ContactId { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage ="Enter valid email address")]
        [DisplayName("Email Id")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid Phone Number")]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage ="Country Required")]
        public string Country { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "State Required")]
        public string State { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "City Required")]
        public string City { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Address Line 1 Required")]
        [DisplayName("Address Line 1")]
        public string AddressLine1 { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Address Line 2 Required")]
        [DisplayName("Address Line 2")]
        public string AddressLine2 { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "Contact Type Required")]
        [DisplayName("Contact Type")]
        public string ContactType { get; set; }
        public Company Company { get; set; }

       
       [DisplayName("Company Name")]
      public int? CompanyId { get; set; }
        public Candidate Candidate { get; set; }

        

          [DisplayName("Candidate Name")]
        public int? CandidateId { get; set; }
    }
}
