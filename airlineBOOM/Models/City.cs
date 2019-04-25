using System.ComponentModel.DataAnnotations;

namespace airlineBOOM.Models
{
    // Custom table
    public class City
    {
        // Parameters
        [Key]
        public string Name { get; set; }

        // To be debated
        public string AirportCondition { get; set; }
        public string TerrainCondition { get; set; }
    }
}
