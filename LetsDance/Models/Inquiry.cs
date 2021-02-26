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


        [StringLength(50)]
        public string InquirerName { get; set; }


        [StringLength(50)]
        public string InquirerEmail { get; set; }


        [StringLength(50)]
        public string InquirerPhone { get; set; }

       
        [StringLength(50)]
        public string InquirerMessage { get; set; }
    }
}
