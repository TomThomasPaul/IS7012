using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsDance.Models
{
    public class ClassSchedule
    {
        public int ClassScheduleId { get; set; }

        [System.ComponentModel.DisplayName("Meeting Day")]
        [Required]
        [StringLength(50)]
        public string MeetingDay { get; set; }

        [System.ComponentModel.DisplayName("Meeting Time")]
        [DataType(DataType.Time)]
        public DateTime MeetingTime { get; set; }

        [System.ComponentModel.DisplayName("Duration ( In Hours )")]
        [Required]
        public int Duration { get; set; }

        [System.ComponentModel.DisplayName("Budding Dancer")]
        public BuddingDancer BuddingDancer { get; set; }

        [System.ComponentModel.DisplayName("Budding Dancer")]
        public int BuddingDancerId { get; set; }
        public Faculty Faculty { get; set; }

        [System.ComponentModel.DisplayName("Faculty")]
        public int FacultyId { get; set; }


    }
}
