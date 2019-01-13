using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class DishContext : DbContext
    {
        public DbSet<Dish> Dishes { get; set; }
        public DishContext(DbContextOptions<DishContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
