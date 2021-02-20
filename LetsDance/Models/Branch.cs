using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsDance.Models
{
    public class Branch
    {


        public int BranchId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public List<BuddingDancer> BuddingDancers { get; set; }
        public List<Faculty> Faculties { get; set; }
    }
}
