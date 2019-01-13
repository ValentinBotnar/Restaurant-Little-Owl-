using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class DrinkContext : DbContext
    {
        public DbSet<Drink> Drinks { get; set; }
        public DrinkContext(DbContextOptions<DrinkContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
