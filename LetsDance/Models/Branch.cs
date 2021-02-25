using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsDance.Models
{
    public class Branch
    {
        public int BranchId { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        public string Phone { get; set; }

        [System.ComponentModel.DisplayName("Address Line 1")]
        [Required]
        [StringLength(50)]
        public string AddressLine1 { get; set; }

        [System.ComponentModel.DisplayName("Address Line 2")]
        [StringLength(50)]
        public string AddressLine2 { get; set; }

        [Required]
        [StringLength(20)]
        public string City { get; set; }

        [Required]
        [StringLength(20)]
        public string State { get; set; }

        [Required]
        public int Zip { get; set; }

        [System.ComponentModel.DisplayName("Budding Dancer")]
        public List<BuddingDancer> BuddingDancers { get; set; }

        [System.ComponentModel.DisplayName("Faculty")]
        public List<Faculty> Faculties { get; set; }

        public string Address

        {
            get

            {
                return $"{AddressLine1} {AddressLine2} {City}";
            }
        }
    }
}
