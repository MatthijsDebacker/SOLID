using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class ArrayPrinter<T> : IPrinter<T[]>
    {
        public void Print(T[] data)
        {
            foreach (var item in data)
            {
                Console.Write($"{item}\n");
            }
        }
    }
}
