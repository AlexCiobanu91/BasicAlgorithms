using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    class MaxLengthIncreasingSubSequence
    {
        private static List<List<int>> buildMatrix(int nLen)
        {
            List<List<int>> mat = new List<List<int>>();
            for (int i = 0; i < nLen; i++)
            {
                List<int> lstRow = new List<int>();
                for (int j = 0; j < nLen; j++)
                {
                    if (i == 0)
                    {
                        lstRow.Add(1);
                    }
                    else
                    {
                        lstRow.Add(0);
                    }
                }
                mat.Add(lstRow);
            }
            return mat;
        }

        private static List<List<int>> BuildSolution(List<List<int>> mat, List<int> lstNumbers, int nMaxRow)
        {
            List<List<int>> sequences = new List<List<int>>();
            for (int i = 0; i< mat.Count - nMaxRow; i++)
            {
                if (mat[nMaxRow][i] != 0)
                {
                    List<int> lstSequence = new List<int>();
                    for (int j = 0; j <= nMaxRow; j ++)
                    {
                        lstSequence.Add(lstNumbers[i + j]);
                    }
                    sequences.Add(lstSequence);
                }
            }
            return sequences;
        }

        public static List<List<int>> Mliss(List<int> lstNumbers)
        {

            int nLen = lstNumbers.Count;
            List<List<int>> A = buildMatrix(nLen);
            int maxLen = 0;
            for (int i = 1; i < nLen; i++)
            {
                bool bIncrement = false;
                for (int j = 0; j < nLen - i; j++)
                {
                    if (lstNumbers[i + j] > lstNumbers[i + j - 1] && A[i - 1][j] != 0)
                    {
                        bIncrement = true;
                        A[i][j] = A[i - 1][j] + 1;
                    }
                }
            
                if (!bIncrement)
                {
                    maxLen = i - 1;
                    break;
                }
            }

            return BuildSolution(A, lstNumbers, maxLen);
        }

        public static void PrintSequences(List<List<int>> sequences)
        {
            foreach(List<int> lst in sequences)
            {
                foreach(int n in lst)
                {
                    Console.Write(n + " ");
                }
                Console.Write("\n");
            }
        }
    }
 
}
