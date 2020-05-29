using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace helloworld.Models
{
    public class Pizzas
    {
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }
}
