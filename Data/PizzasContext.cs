using Microsoft.EntityFrameworkCore;
using helloworld.Models;

namespace helloworld.Data
{
    public class PizzasContext : DbContext
    {
        public PizzasContext(DbContextOptions<PizzasContext> options)
            : base(options)
        {
        }

        public DbSet<Pizzas> Pizzas { get; set; }
    }
}