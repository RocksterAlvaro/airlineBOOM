using airlineBOOM.Models.FlightSettingVariables;
using System;

namespace airlineBOOM.Models
{
    // Custom table
    public class PilotTest
    {
        public void calculatePilotTestScore()
        {
            double tempToTalScore = (PilotVisibilityTest.Score + PilotMeteorologyTest.Score + PilotSetoffTest.Score) / 3;
            PilotTestScore = Math.Round(tempToTalScore, 2);
        }

        // Unique ID
        public string Id { get; set; }

        // The pilot responsible for this test
        public AppUser Pilot { get; set; }

        // FlightSetting of the simulation
        public FlightSetting SimulationSetting { get; set; }
        
        // Pilot scores in each variable
        public Visibility PilotVisibilityTest { get; set; }
        public Meteorology PilotMeteorologyTest { get; set; }
        public Setoff PilotSetoffTest { get; set; }

        // The year of the simulation test
        public DateTime TestYear { get; set; }

        // Total score in the simulation of the pilot
        public double PilotTestScore { get; set; }
    }
}
