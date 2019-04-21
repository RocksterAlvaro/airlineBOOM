using airlineBOOM.Models.FlightSettingVariables;

namespace airlineBOOM.Models
{
    // Custom table
    public class FlightSetting
    {
        public FlightSetting()
        {

        }

        public FlightSetting(Meteorology FlightSettingMeteorology, Visibility FlightSettingVisibility, Setoff FlightSettingSetoff)
        {
            this.FlightSettingMeteorology = FlightSettingMeteorology;
            this.FlightSettingVisibility = FlightSettingVisibility;
            this.FlightSettingSetoff = FlightSettingSetoff;

            double tempToTalScore = (FlightSettingVisibility.Score + FlightSettingMeteorology.Score + FlightSettingSetoff.Score) / 3;
            TotalScore = System.Math.Round(tempToTalScore, 2);
        }

        public void calculateFlightSettingScore()
        {
            double tempToTalScore = (FlightSettingVisibility.Score + FlightSettingMeteorology.Score + FlightSettingSetoff.Score) / 3;
            TotalScore = System.Math.Round(tempToTalScore, 2);
        }

        // Unique ID
        public string Id { get; set; }

        // FlightSetting difficulty value
        public double TotalScore { get; set; }

        // My classes
        public Meteorology FlightSettingMeteorology { get; set; }
        public Visibility FlightSettingVisibility { get; set; }
        public Setoff FlightSettingSetoff { get; set; }
    }
}
