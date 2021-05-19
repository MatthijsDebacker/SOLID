using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class SortingAlgorithmTester
    {

        public List<ISorter> Sorters { get; set; }
        public IPrinter<int[]> Printer { get; }

        public SortingAlgorithmTester(List<ISorter> sorters, IPrinter<int[]> printer)
        {
            Sorters = sorters;
            Printer = printer;
        }

        public void Test(int index)
        {
            int[] array = { 88, 12, 55, 105, 48, 84, 66, 35, 57, 89, 74, 106, 200, 541, 1, 9, 7, 55, 405, 13 };
            Sorters[index].Sort(array);
            Printer.Print(array);
        }

        public void Test()
        {
            for (int i = 0; i < Sorters.Count; i++)
            {
                Test(i);
                Console.WriteLine($"sorting done using {Sorters[i]}, needed {(Sorters[i] as Sorter).Swapped} swaps to sort the array");
                Console.ReadKey();
            }
        }

        public void PrintArray<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item}\n");
            }
        }
    }
}
