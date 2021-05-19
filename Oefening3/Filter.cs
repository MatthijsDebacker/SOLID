using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    class Filter
    {
        public List<Product> FilterMethod(List<Product> list, Colors color)
        {
            List<Product> tmp = new List<Product>();
            foreach (var p in list)
            {
                if (p.Color == color)
                {
                    tmp.Add(p);
                }
            }
            return tmp;
        }

        public List<Product> FilterMethod(List<Product> list, int size)
        {
            List<Product> tmp = new List<Product>();
            foreach (var p in list)
            {
                if (p.Size == size)
                {
                    tmp.Add(p);
                }
            }
            return tmp;
        }

        public List<Product> products(List<Product> list, Colors color, int size)
        {
            List<Product> tmp = new List<Product>();
            foreach (var p in list)
            {
                if (p.Color == color && p.Color == color)
                {
                    tmp.Add(p);
                }
            }
            return tmp;
        }
    }
}
