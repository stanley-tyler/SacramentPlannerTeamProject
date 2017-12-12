using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Sacrament
    {
        public int ID { get; set; }
        public string openSong { get; set; }
        public string closeSong { get; set; }
        public string conductor { get; set; }
        public string openPrayer { get; set; }
        public string closePrayer { get; set; }
        public string openSpeaker { get; set; }
        public string midSpeaker { get; set; }
        public string closeSpeaker { get; set; }
        public DateTime date { get; set; }

       //public ICollection<Enrollment> Enrollments { get; set; }
    }
}
