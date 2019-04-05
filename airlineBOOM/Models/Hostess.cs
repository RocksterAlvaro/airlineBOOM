using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace airlineBOOM.Models
{
    // Custom table
    public class Hostess
    {
        // Unique ID
        public string Id { get; set; }

        // Parameters
        public int IdentityDocument { get; set; }
        public string Name { get; set; }
        public int EmployeeNumber { get; set; }
        public DateTime BornDate { get; set; }
    }
}
