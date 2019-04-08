using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Drink> Drinks { get; set; }
       // public DbSet<RegisterViewModel> Dishes2 { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
