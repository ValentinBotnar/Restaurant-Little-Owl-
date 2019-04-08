using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Context
{
    public class RegistrationContext : IdentityDbContext<User>
    {
        public RegistrationContext(DbContextOptions<RegistrationContext> options)
               : base(options)
        {
            Database.EnsureCreated();
        }

    }
}