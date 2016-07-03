using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    class HeapSort
    {


        private static List<int> Heapify(List<int> lstNumbers)
        {
            
            decimal dFloor = decimal.Floor(lstNumbers.Count / 2);
            for (int i = (int)dFloor; i >= 0; i--)
            {
                int firstChildIndex = -1;
                int secondChildIndex = -1;
                if (lstNumbers.Count > 2 * i + 2)
                {
                    secondChildIndex = 2 * i + 2;
                }

                if (lstNumbers.Count > 2 * i + 1)
                {
                    firstChildIndex = 2 * i + 1;
                }

                int maxChildIndex = -1;
                if (firstChildIndex != -1 && secondChildIndex != -1)
                {
                    maxChildIndex = lstNumbers[firstChildIndex] >= lstNumbers[secondChildIndex] ? firstChildIndex : secondChildIndex;
                }
                else if (secondChildIndex != -1)
                {
                    maxChildIndex = secondChildIndex;
                }
                else
                {
                    maxChildIndex = firstChildIndex;
                }
                if (maxChildIndex != -1)
                {
                    if (lstNumbers[i] < lstNumbers[maxChildIndex])
                    {
                        int temp = lstNumbers[i];
                        lstNumbers[i] = lstNumbers[maxChildIndex];
                        lstNumbers[maxChildIndex] = temp;
                    }
                }
            }
            return lstNumbers;
        }

        public static List<int> Sort(List<int> lstNumbers, bool Descending = false)
        {
            List<int> lstSorted = new List<int>();
            lstNumbers = Heapify(lstNumbers);
            while (lstNumbers.Count > 0)
            {
                int nEnd = lstNumbers.Count - 1;

                int temp = lstNumbers[nEnd];
                lstNumbers[nEnd] = lstNumbers[0];
                lstNumbers[0] = temp;

                lstSorted.Add(lstNumbers[nEnd]);

                lstNumbers.RemoveAt(nEnd);
                lstNumbers = Heapify(lstNumbers);
            }
            return !Descending ? lstSorted : lstSorted.Reverse<int>().ToList();
        }

    }
}
