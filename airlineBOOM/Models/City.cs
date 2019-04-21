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
        public string airportCondition { get; set; }
        public string terrainCondition { get; set; }
    }
}
