using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatThoma2tp.Models
{
    public class Industry
    {

        public int IndustryId { get; set; }

        [StringLength(25)]
        [Required(ErrorMessage = "Industry Name is required")]
        [DisplayName("Industry Name")]
        public string IndustryName { get; set; }

        [StringLength(25)]
        [Required(ErrorMessage = "Industry Type is required")]
        [DisplayName("Industry Type")]
        public string IndustryType { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
    }
}
