using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    class QuickSort
    {
        public List<int> lstNumbers { get; set; }

        public QuickSort(List<int> lstNumbers)
        {
            this.lstNumbers = lstNumbers;
        }

        public void Sort(int inf, int sup, bool descending = false)
        {
            int i = inf;
            int j = sup;
            int pivot = lstNumbers[(i + j) / 2];

            do
            {
                while (i < sup && lstNumbers[i] < pivot) i++;
                while (j > inf && lstNumbers[j] > pivot) j--;
                if(i <= j)
                {
                    int temp = lstNumbers[i];
                    lstNumbers[i] = lstNumbers[j];
                    lstNumbers[j] = temp;
                    i++;
                    j--;
                }                           
            } while (i <= j);
            if (inf < j) Sort(inf, j);
            if (i < sup) Sort(i, sup);
        }
    }
}
