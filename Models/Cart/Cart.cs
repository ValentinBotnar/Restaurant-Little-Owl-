    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Cart
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(Dish dish, int quantity)
        {
            CartLine line = lineCollection
                .Where(g => g.dish.Id == dish.Id)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    dish = dish,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Dish dish)
        {
            lineCollection.RemoveAll(l => l.dish.Id == dish.Id);
        }

        public double ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.dish.Price * e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }

    public class CartLine
    {
        public Dish dish { get; set; }
        public int Quantity { get; set; }
    }
}

