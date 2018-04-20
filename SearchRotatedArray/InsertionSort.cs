using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    public class InsertionSort
    {
        public static int[] SortArray(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < A[i-1])
                {
                    int j = i - 1;
                    int k = i;
                    while(j >= 0 && A[k] < A[j])
                    {
                        int temp = A[k];
                        A[k] = A[j];
                        A[j] = temp;

                        j--;
                        k--;
                    }
                }
            }

            return A;
        }
    }
}
