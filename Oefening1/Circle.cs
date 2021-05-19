using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    class Circle : Shape
    {
        public int straal;
        public Circle(int s)
        {
            straal = s;
        }
        public override double Surface()
        {
            return straal * straal * Math.PI;
        }
    }
}
