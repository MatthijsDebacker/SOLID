using System;
using System.Collections.Generic;

namespace SortingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISorter> sorters = new List<ISorter>();
            sorters.Add(new QuickSorter());
            sorters.Add(new ShakeSorter());
            sorters.Add(new BubbleSorter());

            SortingAlgorithmTester tester = new SortingAlgorithmTester(sorters, new ArrayPrinter<int>());

            tester.Test();
        }
    }
}
