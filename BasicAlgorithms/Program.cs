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
            List<int> lstSorted = HeapSort.Sort(lstNumbers, true);
            foreach (int i in lstSorted.Reverse<int>())
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
