using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionApp
{
    public class LoggingBasket : IBasket
    {
        private readonly IBasket childBasket;

        public LoggingBasket(IBasket childBasket)
        {
            this.childBasket = childBasket;
        }
        public List<string> Items => childBasket.Items;

        public void Add(string item)
        {
            Console.WriteLine("Record into log");
            childBasket.Add(item);
        }

        public void Delete(string item)
        {
            throw new NotImplementedException();
        }
    }
}
