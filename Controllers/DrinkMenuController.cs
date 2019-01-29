using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class DrinkMenuController : Controller
    {
        private ApplicationContext dbDrink;

        public DrinkMenuController(ApplicationContext context)
        {
            dbDrink = context;
        }

        public async Task<IActionResult> ShowDrinks()
        {
            return View(await dbDrink.Drinks.ToListAsync());
        }
    }
}