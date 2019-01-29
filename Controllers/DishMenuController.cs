using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class DishMenuController : Controller
    {
        private ApplicationContext dbDish;

        public DishMenuController(ApplicationContext context)
        {
            dbDish = context;
        }

        public async Task<IActionResult> ShowDishes()
        {
            return View(await dbDish.Dishes.ToListAsync());
        }
    }
}