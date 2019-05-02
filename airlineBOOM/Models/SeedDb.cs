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
            // Seed DB
            using (var _db = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                Console.WriteLine("\n Looking for a database... \n");

                // Look for a database
                if (!_db.Database.EnsureCreated())
                {
                    // Debug message
                    string message = "\n There is already a database. \n";
                    Console.WriteLine(message);

                    // DB has been seeded before
                }
                else
                {
                    // Debug message
                    string message = "\n A new database has been created. \n";
                    Console.WriteLine(message);

                    // Create & seed meteorology, visibility & setoff values in the database
                    #region metereology, visibility & setoff values
                    // Seed meteorology values
                    _db.Meteorologies.AddRange(
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
                    _db.Visibilities.AddRange(
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
                    _db.Setoffs.AddRange(
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

                    // Create & seed default flight settings
                    #region Create default flight settings
                    // Seed default flight settings
                    _db.FlightSettings.AddRange(
                        new FlightSetting(
                            _db.Meteorologies.Find(2.0),
                            _db.Visibilities.Find(2.0),
                            _db.Setoffs.Find(2.0)
                            ),
                        new FlightSetting(
                            _db.Meteorologies.Find(2.0),
                            _db.Visibilities.Find(6.0),
                            _db.Setoffs.Find(2.0)
                            ),
                        new FlightSetting(
                            _db.Meteorologies.Find(7.0),
                            _db.Visibilities.Find(2.0),
                            _db.Setoffs.Find(2.0)
                            ),
                        new FlightSetting(
                            _db.Meteorologies.Find(2.0),
                            _db.Visibilities.Find(2.0),
                            _db.Setoffs.Find(8.0)
                            ),
                        new FlightSetting(
                            _db.Meteorologies.Find(6.0),
                            _db.Visibilities.Find(5.0),
                            _db.Setoffs.Find(8.0)
                            )
                    );
                    #endregion

                    // Create & seed cities values
                    #region Create cities values
                    // Seed cities values
                    _db.Cities.AddRange(
                        new City
                        {
                            Name = "bucaramanga"
                        },
                        new City
                        {
                            Name = "cucuta"
                        },
                        new City
                        {
                            Name = "bogota"
                        },
                        new City
                        {
                            Name = "medellin"
                        }
                    );
                    #endregion

                    // Create & seed flights values
                    #region Create flights values

                    // Find cities for the seed flight
                    City bogota = _db.Cities.Find("bogota");
                    City bucaramanga = _db.Cities.Find("bucaramanga");
                    City cucuta = _db.Cities.Find("cucuta");
                    City medellin = _db.Cities.Find("medellin");

                    // Seed flights values
                    _db.Flights.AddRange(
                        new Flight
                        {
                            Hours = 3,
                            AirplaneState = "Fine",
                            TicketsSold = 30,
                            Origin = bogota,
                            Destiny = bucaramanga
                        },
                        new Flight
                        {
                            Hours = 2,
                            AirplaneState = "Regular",
                            TicketsSold = 25,
                            Origin = medellin,
                            Destiny = cucuta
                        },
                        new Flight
                        {
                            Hours = 5,
                            AirplaneState = "Excelent",
                            TicketsSold = 40,
                            Origin = medellin,
                            Destiny = bogota
                        }
                    );
                    #endregion

                    // Save the data samples
                    _db.SaveChanges();

                    // DB has been seeded now
                }
            }
        }

        public static async Task CreateRoles(IServiceProvider serviceProvider)

        {
            //adding customs roles
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            var UserManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();

            // Roles in the project
            string[] roleNames = { "Pilot", "Office", "FlightOperator", "Hostess" };

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

            #region Create custom users & set respective roles
            // create custom users
            var officeUser = new AppUser
            {
                UserName = "paulita",
                Email = "paulita@",
                Password = "paulita"

            };

            var pilots = new AppUser[] {
                new AppUser
                {
                    Name = "pablito",
                    IdentityDocument = 80421514,
                    EmployeeNumber = 52641958,
                    UserName = "pcastellanos",
                    Email = "pablito@",
                    Password = "pablito",
                    BornDate = new DateTime(1990, 6, 20)
                },
                new AppUser
                {
                    Name = "pedrito",
                    IdentityDocument = 1098808192,
                    EmployeeNumber = 62549214,
                    UserName = "privero",
                    Email = "pedrito@",
                    Password = "pedrito",
                    BornDate = new DateTime(1992, 8, 10)
                },
                new AppUser
                {
                    Name = "juanito",
                    IdentityDocument = 68291219,
                    EmployeeNumber = 79542618,
                    UserName = "jlopez",
                    Email = "juanito@",
                    Password = "juanito",
                    BornDate = new DateTime(1988, 2, 16)
                }
            };

            var flightOperatorUser = new AppUser
            {
                UserName = "alvaro",
                Email = "alvaro@",
                Password = "alvaro"

            };

            foreach (var pilot in pilots)
            {
                await UserManager.CreateAsync(pilot, pilot.Password);
                await UserManager.AddToRoleAsync(pilot, "Pilot");
            }

            await UserManager.CreateAsync(officeUser, officeUser.Password);
            await UserManager.AddToRoleAsync(officeUser, "Office");


            await UserManager.CreateAsync(flightOperatorUser, flightOperatorUser.Password);
            await UserManager.AddToRoleAsync(flightOperatorUser, "FlightOperator");
            #endregion

            using (var _db = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                Random rnd = new Random();

                var meteorologies = await _db.Meteorologies.ToArrayAsync();
                var visibilities = await _db.Visibilities.ToArrayAsync();
                var setoffs = await _db.Setoffs.ToArrayAsync();

                // Create & seed random test pilots test
                var myPilots = await UserManager.GetUsersInRoleAsync("Pilot");
                var flightSettings = await _db.FlightSettings.ToArrayAsync();
                foreach (var pilot in pilots)
                {
                    foreach (var flightSetting in flightSettings)
                    {
                        await _db.PilotTests.AddAsync(
                            new PilotTest
                            {
                                PilotId = pilot.Id,
                                SimulationSetting = flightSetting,
                                PilotMeteorologyTest = meteorologies[rnd.Next(0, meteorologies.Length-1)],
                                PilotVisibilityTest = visibilities[rnd.Next(0, visibilities.Length - 1)],
                                PilotSetoffTest = setoffs[rnd.Next(0, setoffs.Length - 1)]
                                
                            }
                        );
                    }
                }

                // Save the data samples
                _db.SaveChanges();
                
            }
            
        }
    }
}
