using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionApp
{
    public class FileBasket : IBasket
    {
        public List<string> Items => throw new NotImplementedException();

        public void Add(string item)
        {
            throw new NotImplementedException();
        }

        public void Delete(string item)
        {
            throw new NotImplementedException();
        }
    }
}
