using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    public enum Colors
    {
        Yellow,
        Green,
        Blue
    }

    class Product
    {
        public string Name { get; set; }
        public Colors Color { get; set; }
        public int Size { get; set; }
    }
}
