using System.ComponentModel.DataAnnotations;

namespace airlineBOOM.Models.FlightSettingVariables
{
    // Custom table
    public class Visibility
    {
        // Parameters
        [Key]
        public double Score { get; set; }
        public string Name { get; set; }
    }
}
