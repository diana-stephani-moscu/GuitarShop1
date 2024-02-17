using GuitarShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Humanizer.Localisation;

namespace GuitarShop.Data

{
    public class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Guitar.Any())
                {
                    return;
                }

                var guitar = new List<Guitar>
                {
                    new Guitar
                    { Name = "Acoustic Guitar",
                        Colour = "Brown",
                        Shape = "Acoustic",
                        Type = "Acoustic",
                        Price = Decimal.Parse("250"),
                    },
                    new Guitar
                    { Name = "Classical Guitar",
                        Colour = "Brown",
                        Shape = "Classical Guitar",
                        Type = "Classical Guitar",
                        Price = Decimal.Parse("150"),
                    },
                    new Guitar
                    { Name = "Black Les Paul",
                        Colour = "Black",
                        Shape = "Les Paul",
                        Type = "Electric",
                        Price = Decimal.Parse("380"),
                    },
                    new Guitar
                    { Name = "Gold Les Paul",
                        Colour = "Gold",
                        Shape = "Les Paul",
                        Type = "Electric",
                        Price = Decimal.Parse("500"),
                    },
                    new Guitar
                    { Name = "Original Les Paul",
                        Colour = "Original",
                        Shape = "Les Paul",
                        Type = "Electric",
                        Price = Decimal.Parse("425"),
                    },
                    new Guitar
                    { Name = "Red Les Paul",
                        Colour = "Red",
                        Shape = "Les Paul",
                        Type = "Electric",
                        Price = Decimal.Parse("325"),
                    },
                    new Guitar
                    { Name = "Black Stratocaster",
                        Colour = "Black",
                        Shape = "Stratocaster",
                        Type = "Electric",
                        Price = Decimal.Parse("285"),
                    },
                    new Guitar
                    { Name = "Blue Stratocaster",
                        Colour = "Blue",
                        Shape = "Stratocaster",
                        Type = "Electric",
                        Price = Decimal.Parse("210"),
                    },
                    new Guitar
                    { Name = "Red Stratocaster",
                        Colour = "Red",
                        Shape = "Stratocaster",
                        Type = "Electric",
                        Price = Decimal.Parse("260"),
                    },
                    new Guitar
                    { Name = "White Stratocaster",
                        Colour = "White",
                        Shape = "Stratocaster",
                        Type = "Electric",
                        Price = Decimal.Parse("195"),
                    },
                    new Guitar
                    { Name = "White Telecaster",
                        Colour = "White",
                        Shape = "Telecaster",
                        Type = "Electric",
                        Price = Decimal.Parse("300"),
                    },
                    new Guitar
                    { Name = "Yellow Telecaster",
                        Colour = "Yellow",
                        Shape = "Telecaster",
                        Type = "Electric",
                        Price = Decimal.Parse("350"),
                    },
                };



                {
                    context.SaveChanges();
                }
            }
        }
    } 
}
