using airlineBOOM.Data;
using airlineBOOM.Models.FlightSettingVariables;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace airlineBOOM.Models
{
    public class Seeds
    {
        public static void SeedDatabase(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {

                // Look for any data
                if (!context.Database.EnsureCreated())
                {
                    // Debug message
                    string message = "\n There is already a database. \n";
                    Console.WriteLine(message);

                    return; // DB has been seeded before
                }
                else
                {
                    // Debug message
                    string message = "\n A new database has been created. \n";
                    Console.WriteLine(message);

                    // Create meteorology, visibility & setoff values in the database
                    #region seed database with metereology, visibility & setoff values
                    // Create meteorology values in the database
                    
                    context.Meteorologies.AddRange(
                        new Meteorology
                        {
                            Score = 0,
                            Name = "Clear sky"
                        },
                        new Meteorology
                        {
                            Score = 1,
                            Name = "Mostly clear sky"
                        },
                        new Meteorology
                        {
                            Score = 2,
                            Name = "Half clear sky"
                        },
                        new Meteorology
                        {
                            Score = 3,
                            Name = "Small clear sky"
                        },
                        new Meteorology
                        {
                            Score = 4,
                            Name = "Small sky with clouds"
                        },
                        new Meteorology
                        {
                            Score = 5,
                            Name = "Half sky with clouds"
                        },
                        new Meteorology
                        {
                            Score = 6,
                            Name = "Mostly sky with clouds"
                        },
                        new Meteorology
                        {
                            Score = 7,
                            Name = "Sky with clouds"
                        },
                        new Meteorology
                        {
                            Score = 8,
                            Name = "Sky with dark clouds"
                        },
                        new Meteorology
                        {
                            Score = 9,
                            Name = "Dangerous sky with dark clouds"
                        },
                        new Meteorology
                        {
                            Score = 10,
                            Name = "Extremely dangerous sky with dark clouds"
                        }
                    );
                    
                    // Create visibility values in the database
                    context.Visibilities.AddRange(
                        new Visibility
                        {
                            Score = 0,
                            Name = "Clear view"
                        },
                        new Visibility
                        {
                            Score = 1,
                            Name = "Mostly clear view"
                        },
                        new Visibility
                        {
                            Score = 2,
                            Name = "Half clear view"
                        },
                        new Visibility
                        {
                            Score = 3,
                            Name = "Small clear view"
                        },
                        new Visibility
                        {
                            Score = 4,
                            Name = "Flight with small short views"
                        },
                        new Visibility
                        {
                            Score = 5,
                            Name = "Flight with half short views"
                        },
                        new Visibility
                        {
                            Score = 6,
                            Name = "Flight with mostly short views"
                        },
                        new Visibility
                        {
                            Score = 7,
                            Name = "All flight with short view"
                        },
                        new Visibility
                        {
                            Score = 8,
                            Name = "All flight with irregular short view"
                        },
                        new Visibility
                        {
                            Score = 9,
                            Name = "All flight with dangerous short view"
                        },
                        new Visibility
                        {
                            Score = 10,
                            Name = "All flight with extremely dangerous short view"
                        }
                    );

                    // Create Setoff values in the database
                    context.Setoffs.AddRange(
                        new Setoff
                        {
                            Score = 0,
                            Name = "Plain terrain"
                        },
                        new Setoff
                        {
                            Score = 1,
                            Name = "Mostly plain terrain"
                        },
                        new Setoff
                        {
                            Score = 2,
                            Name = "Half plain terrain"
                        },
                        new Setoff
                        {
                            Score = 3,
                            Name = "Small plain terrain"
                        },
                        new Setoff
                        {
                            Score = 4,
                            Name = "Small highland terrain"
                        },
                        new Setoff
                        {
                            Score = 5,
                            Name = "Half highland terrain"
                        },
                        new Setoff
                        {
                            Score = 6,
                            Name = "Mostly highland terrain"
                        },
                        new Setoff
                        {
                            Score = 7,
                            Name = "Highland terrain"
                        },
                        new Setoff
                        {
                            Score = 8,
                            Name = "Irregular highland terrain"
                        },
                        new Setoff
                        {
                            Score = 9,
                            Name = "Dangerous highland terrain"
                        },
                        new Setoff
                        {
                            Score = 10,
                            Name = "Extremely dangerous highland terrain"
                        }
                    );
                    #endregion

                    // Save the data samples
                    context.SaveChanges();

                    return; // DB has been seeded now
                }
            }
        }

        public static async Task CreateRoles(IServiceProvider serviceProvider, IConfiguration Configuration)

        {
            //adding customs roles
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            var UserManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();

            // Roles in the project
            string[] roleNames = { "Pilot", "Office", "FlightOperator" };

            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {

                // creating the roles and seeding them to the database
                var roleExist = await RoleManager.RoleExistsAsync(roleName);

                if (!roleExist)

                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }

            }
        }
    }
}
