using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace airlineBOOM.Models
{
    // My application user class inherit all attributes from IdentityUser
    public class AppUser : IdentityUser
    {
        // Custom variables on users
        public string Name { get; set; }
        public int IdentityDocument { get; set; }
        public int EmployeeNumber { get; set; }
        public DateTime BornDate { get; set; }

        // For debug purpose of the debugging
        public string Password { get; set; }

        // Pilot Shit
        // Make a request to the databse to know which flights have done the pilot
        // Count the above request
        // Sum the hours on the above | I can also create a varible. I'll probably reconsider.
        // Make a request to the database to know which flights that havent flown have this pilot
        // Make a request to the database to know which simulation test are asigned to this pilot
    }
}
