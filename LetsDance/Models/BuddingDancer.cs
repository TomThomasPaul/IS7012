﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsDance.Models
{
    public class BuddingDancer
    {

        public int BuddingDancerId { get; set; }

        [System.ComponentModel.DisplayName("First Name")]
        [Required]
        [StringLength(50)]
        public string DancerFirstName { get; set; }

        [System.ComponentModel.DisplayName("Last Name")]
        [Required]
        [StringLength(50)]
        public string DancerLastName { get; set; }

        [System.ComponentModel.DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DancerBirthDate { get; set; }

        [System.ComponentModel.DisplayName("Joining Date")]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }

        [DisplayName(" Past Student ")]
        public bool PastStudent { get; set; }


        public Genre Genre { get; set; }

        [System.ComponentModel.DisplayName("Genre")]
        public int GenreId { get; set; }
        public Branch Branch { get; set; }

        [System.ComponentModel.DisplayName("Location")]
        public int BranchId { get; set; }

        [System.ComponentModel.DisplayName("Class Schedule")]
        public List<ClassSchedule> ClassSchedules { get; set; }

        public string DancerFullName

        { get

            {
                return $"{DancerFirstName} {DancerLastName}";
            }
        }
       

    }
}
