using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    class Square : Shape
    {
        public int lengte;
        public Square(int l)
        {
            lengte = l;
        }
        public override double Surface()
        {
            return lengte * lengte;
        }
    }
}
