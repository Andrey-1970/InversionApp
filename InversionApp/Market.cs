using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionApp
{
    public class Market
    {
        private List<string> items;
        public readonly IBasket basket;
        public Market(IBasket basket)
        {
            this.items = new List<string>();
            this.basket = basket;
        }
        public void Add(string item)
        {
            this.items.Add(item);
        }
        public List<string> Items { get { return this.items; } }
        public void AddItemToBasket(string item)
        {
            basket.Add(item);
        }
        public List<string> GetBasketItems()
        {
            return basket.Items;
        }
    }
}
