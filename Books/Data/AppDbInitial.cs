using Books.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Data
{
    public class AppDbInitial
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
           using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "Dune",
                        Description = "Future Si-fi",
                        IsRead = true, 
                        DateRead = DateTime.Now.AddDays(-10),
                        Genre = "Si-fi",
                        Rate = 5,
                        CoverUrl = "",
                        DateAdded = DateTime.Now
                    }, new Book()
                    {
                        Title = "Dune2",
                        Description = "Future Si-fi",
                        IsRead = false,
                        Genre = "Si-fi",
                        CoverUrl = "",
                        DateAdded = DateTime.Now
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
