using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using helloworld.Data;
using System;
using System.Linq;

namespace helloworld.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PizzasContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PizzasContext>>()))
            {
                // Look for any movies.
                if (context.Pizzas.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pizzas.AddRange(
                    new Pizzas
                    {
                        PizzaName = "When Harry Met Sally",
                        Description = "1989-2-12",
                        Category = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Pizzas
                    {
                        PizzaName = "Ghostbusters ",
                        Description = "1984-3-13",
                        Category = "Comedy",
                        Price = 8.99M
                    },

                    new Pizzas
                    {
                        PizzaName = "Ghostbusters 2",
                        Description = "1986-2-23",
                        Category = "Comedy",
                        Price = 9.99M
                    },

                    new Pizzas
                    {
                        PizzaName = "Rio Bravo",
                        Description = "1959-4-15",
                        Category = "Western",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}