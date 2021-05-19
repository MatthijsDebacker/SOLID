using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    class SurfaceCalculator
    {
        List<Shape> list;
        public SurfaceCalculator()
        {
            // Replace by dependency injection
            list = new List<Shape>();
        }
        public void Add(Shape s)
        {
            list.Add(s);
        }

        private double Sum()
        {
            double total = 0.0;
            foreach (Shape s in list)
            {
                total += s.Surface();
            }
            return total;
        }

        // SRP
        //public string Output()
        //{
        //    return "<h1> Totale som = " + Sum() + " </h1> ";
        //}

        public override string ToString()
        {
            return "<h1> Totale som = " + Sum() + " </h1> ";
        }
    }
}
