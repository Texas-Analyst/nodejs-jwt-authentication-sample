using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ColourAPI.Models;

namespace ColourAPI.Data
{
    public static class PrepDb
    {
        public static List<Colour> ColourItems { get; set; }  // = new List<Colour>();

        public static void PrepPopulation(IApplicationBuilder appBldr)
        {

            using (IServiceScope svcScope = appBldr.ApplicationServices.CreateScope())
            {
                SeedData(svcScope.ServiceProvider.GetService<ColourContext>());
            }
        }

        public static void SeedData(ColourContext colourCtx)
        {

            if(colourCtx != null)
            {
                Console.WriteLine("Applying Migrations .....");
                colourCtx.Database.Migrate();
                if (!colourCtx.ColourItems.Any())
                {
                    Console.WriteLine("Adding data - seeding ");
                    ColourItems = new List<Colour> { 
                        new Colour { Id = 1, ColourName = "Red" },
                        new Colour { Id = 2, ColourName = "Orange" },
                        new Colour { Id = 3, ColourName = "Yellow" },
                        new Colour { Id = 4, ColourName = "Green" },
                        new Colour { Id = 5, ColourName = "Blue" },
                        new Colour { Id = 6, ColourName = "Pink" }
                        };
                }
                else
                {
                    Console.WriteLine("Already have data - seeding unnecessary");
                }
            }
            
        }
    }
}
