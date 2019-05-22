using airlineBOOM.Models.FlightSettingVariables;
using System;
using System.ComponentModel.DataAnnotations;

namespace airlineBOOM.Models
{
    // Custom table
    public class PilotTest
    {
        // Empty constructor
        public PilotTest()
        {

        }

        // Constructor with arguments
        public PilotTest(
            Random rnd,
            string PilotId,
            Meteorology[] meteorologies,
            Visibility[] visibilities,
            Setoff[] setoffs,
            FlightSetting SimulationSetting)
        {
            // Assign variables
            this.PilotId = PilotId;
            this.SimulationSetting = SimulationSetting;
            PilotMeteorologyTest = meteorologies[rnd.Next(0, meteorologies.Length - 1)];
            PilotVisibilityTest = visibilities[rnd.Next(0, visibilities.Length - 1)];
            PilotSetoffTest = setoffs[rnd.Next(0, setoffs.Length - 1)];

            // Calculate total test score
            double tempToTalScore = (PilotVisibilityTest.Score + PilotMeteorologyTest.Score + PilotSetoffTest.Score) / 3;
            PilotTestScore = Math.Round(tempToTalScore, 2);
        }

        // Method to calculate total test score
        public void CalculatePilotTestScore()
        {
            double tempToTalScore = (PilotVisibilityTest.Score + PilotMeteorologyTest.Score + PilotSetoffTest.Score) / 3;
            PilotTestScore = Math.Round(tempToTalScore, 2);
        }

        // Unique ID
        [Key]
        public string Id { get; set; }

        // The pilot responsible for this test
        public string PilotId { get; set; }

        // FlightSetting of the simulation
        public FlightSetting SimulationSetting { get; set; }

        // Pilot scores in each variable
        public Meteorology PilotMeteorologyTest { get; set; }
        public Visibility PilotVisibilityTest { get; set; }
        public Setoff PilotSetoffTest { get; set; }

        // The year of the simulation test
        public DateTime TestYear { get; set; }

        // Total score in the simulation of the pilot
        public double PilotTestScore { get; set; }
    }
}
