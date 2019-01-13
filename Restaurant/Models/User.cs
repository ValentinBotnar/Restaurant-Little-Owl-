using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class User : IdentityUser
    {
       // public string Id { get; set; }
      //  public string Name { get; set; }
        public int Year { get; set; }
      //  public string PhoneNumber { get; set; }
       // public string Adress { get; set; }
    }
}
