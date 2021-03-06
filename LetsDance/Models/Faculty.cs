﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsDance.Models
{
    public class Faculty
    {
        public int FacultyId { get; set; }

        [System.ComponentModel.DisplayName("First Name")]
        [Required]
        [StringLength(50)]
        public string FacultyFirstName { get; set; }

        [System.ComponentModel.DisplayName("Last Name")]
        [Required]
        [StringLength(50)]
        public string FacultyLastName { get; set; }

        [Range(0, 100000)]
        public decimal? Salary { get; set; }
        public int Experience { get; set; }
        public Branch Branch { get; set; }

        [System.ComponentModel.DisplayName("Branch")]
        public int BranchId { get; set; }

        [System.ComponentModel.DisplayName("Class Schedule")]
        public List<ClassSchedule> ClassSchedules { get; set; }
        public Genre Genre { get; set; }

        [System.ComponentModel.DisplayName("Genre")]
        public int GenreId { get; set; }

        public string FacultyFullName

        {
            get

            {
                return $"{FacultyFirstName} {FacultyLastName}";
            }
        }

    }
}
