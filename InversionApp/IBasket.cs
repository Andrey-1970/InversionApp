using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionApp
{
    public interface IBasket
    {
        void Add(string item);
        void Delete(string item);
        List<string> Items { get; }
    }
}
