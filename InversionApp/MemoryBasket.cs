using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionApp
{
    public class MemoryBasket : IBasket
    {
        public List<string> Items;

        public MemoryBasket()
        {
            Items = new List<string>();
        }

        List<string> IBasket.Items => Items;

        public void Add(string item)
        {
            Items.Add(item);
        }

        public void Delete(string item)
        {
            throw new NotImplementedException();
        }
    }
}
