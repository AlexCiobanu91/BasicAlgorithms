using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    class Program
    {
        static List<int> lstNumbers = new List<int> { 1, 10, 19, 25, 34, 23, 65, 74, 324, 354, 12, 54, 76, 435 };
        static void Main(string[] args)
        {
            // HeapSort
            List<int> lstSorted = HeapSort.Sort(new List<int>(lstNumbers), descending: false);
            foreach (int i in lstSorted)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            // QuickSort
            QuickSort qs = new QuickSort(new List<int>(lstNumbers));
            qs.Sort(0, lstNumbers.Count - 1);
            lstSorted = qs.lstNumbers;

            foreach (int i in lstSorted)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
