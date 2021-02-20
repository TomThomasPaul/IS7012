using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsDance.Models
{
    public class BuddingDancer
    {

        public int BuddingDancerId { get; set; }
        public string DancerFirstName { get; set; }
        public string DancerLastName { get; set; }
        public DateTime DancerBirthDate { get; set; }
        public DateTime JoiningDate { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public Branch Branch { get; set; }
        public int BranchId { get; set; }
        public List<ClassSchedule> ClassSchedules { get; set; }
       

    }
}
