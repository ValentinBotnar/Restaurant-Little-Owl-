using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Models;
using Restaurant.Models.Cart;
using Restaurant.Models.Context;

namespace Restaurant.Controllers
{
    [Route("cart")]
    public class CartController : Controller
    {
        //  DishContext db = new DishContext();///////////
        public ApplicationContext dbDish2;

        public CartController(ApplicationContext context)
        {
            dbDish2 = context;
        }

        public IActionResult Index()
        {
            

            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
          //  ViewBag.cart = cart;
          //  ViewBag.total = cart.Sum(item => item.dish.Price * item.Quantity);
          
            return View(cart);
        }

        [Route("buy/{id}")]
        public IActionResult Buy(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();

                cart.Add(new Item { dish = dbDish2.Dishes.Find(id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { dish = dbDish2.Dishes.Find(id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            
            return RedirectToAction("Index");
        }
        
        [Route("remove/{id}")]
        public IActionResult Remove(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }

        private int isExist(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].dish.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
        
    }
}