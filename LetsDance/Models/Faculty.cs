using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsDance.Models
{
    public class Faculty
    {


        public int FacultyId { get; set; }
        public string FacultyFirstName { get; set; }
        public string FacultyLastName { get; set; }
        public decimal? Salary { get; set; }
        public Branch Branch { get; set; }
        public int BranchId { get; set; }
        public int Experience { get; set; }
        public List<ClassSchedule> ClassSchedules { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }

    }
}
