using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ChurchContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Sacrament.Any())
            {
                return;   // DB has been seeded
            }

            var planner = new Sacrament[]
            {
            new Sacrament{openSong="The Morning Breaks",conductor="First Councilor",openPrayer="Alexander Hamilton",openSpeaker="Jake Jackson",midSpeaker="Judith Jumbleton",closeSpeaker="Jon Jacob",closeSong="Spirit of God",closePrayer="Lebold Lemon",date=DateTime.Parse("2005-09-01")},
            new Sacrament{openSong="The Morning Breaks",conductor="First Councilor",openPrayer="Alexander Hamilton",openSpeaker="Jake Jackson",midSpeaker="Judith Jumbleton",closeSpeaker="Jon Jacob",closeSong="Spirit of God",closePrayer="Lebold Lemon",date=DateTime.Parse("2005-09-01")},
            new Sacrament{openSong="The Morning Breaks",conductor="First Councilor",openPrayer="Alexander Hamilton",openSpeaker="Jake Jackson",midSpeaker="Judith Jumbleton",closeSpeaker="Jon Jacob",closeSong="Spirit of God",closePrayer="Lebold Lemon",date=DateTime.Parse("2005-09-01")},
            new Sacrament{openSong="The Morning Breaks",conductor="First Councilor",openPrayer="Alexander Hamilton",openSpeaker="Jake Jackson",midSpeaker="Judith Jumbleton",closeSpeaker="Jon Jacob",closeSong="Spirit of God",closePrayer="Lebold Lemon",date=DateTime.Parse("2005-09-01")},
            new Sacrament{openSong="The Morning Breaks",conductor="First Councilor",openPrayer="Alexander Hamilton",openSpeaker="Jake Jackson",midSpeaker="Judith Jumbleton",closeSpeaker="Jon Jacob",closeSong="Spirit of God",closePrayer="Lebold Lemon",date=DateTime.Parse("2005-09-01")},
            new Sacrament{openSong="The Morning Breaks",conductor="First Councilor",openPrayer="Alexander Hamilton",openSpeaker="Jake Jackson",midSpeaker="Judith Jumbleton",closeSpeaker="Jon Jacob",closeSong="Spirit of God",closePrayer="Lebold Lemon",date=DateTime.Parse("2005-09-01")},
            new Sacrament{openSong="The Morning Breaks",conductor="First Councilor",openPrayer="Alexander Hamilton",openSpeaker="Jake Jackson",midSpeaker="Judith Jumbleton",closeSpeaker="Jon Jacob",closeSong="Spirit of God",closePrayer="Lebold Lemon",date=DateTime.Parse("2005-09-01")},
            new Sacrament{openSong="The Morning Breaks",conductor="First Councilor",openPrayer="Alexander Hamilton",openSpeaker="Jake Jackson",midSpeaker="Judith Jumbleton",closeSpeaker="Jon Jacob",closeSong="Spirit of God",closePrayer="Lebold Lemon",date=DateTime.Parse("2005-09-01")}
            };
            foreach (Sacrament s in planner)
            {
                context.Sacrament.Add(s);
            }
            context.SaveChanges();
        }
    }
}
