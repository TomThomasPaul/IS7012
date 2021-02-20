using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsDance.Models
{
    public class ClassSchedule
    {

        public int ClassScheduleId { get; set; }
        public string MeetingDay { get; set; }
        public DateTime MeetingTime { get; set; }
        public int Duration { get; set; }
        public BuddingDancer BuddingDancer { get; set; }
        public int BuddingDancerId { get; set; }
        public Faculty Faculty { get; set; }
        public int FacultyId { get; set; }


    }
}
