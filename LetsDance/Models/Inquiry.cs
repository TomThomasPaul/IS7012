using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LetsDance.Models
{
    public class Inquiry
    {
        
        public int InquiryId { get; set; }

        [Required]
        [System.ComponentModel.DisplayName("Name")]
        [StringLength(50)]
        public string InquirerName { get; set; }

        [Required]
        [System.ComponentModel.DisplayName("Email")]
        [StringLength(50)]
        public string InquirerEmail { get; set; }

        [Required]
        [System.ComponentModel.DisplayName("Phone")]
        [StringLength(50)]
        public string InquirerPhone { get; set; }

        [Required]
        [System.ComponentModel.DisplayName("Message")]
        [StringLength(50)]
        public string InquirerMessage { get; set; }
    }
}
