using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    // https://www.educative.io/collection/page/5642554087309312/5679846214598656/190003/preview
    class QuickSort
    {
        public static void QuickSortArray(int[] A, int start, int end)
        {
             if (start < end)
            {
                int pivot = UsePivot(A, start, end);
                QuickSortArray(A, start, pivot - 1);
                QuickSortArray(A, pivot + 1, end);
            }
        }

        static int UsePivot(int[] A, int start, int end)
        {
            int pivot = A[end];
            int k = start - 1;

            for (int i = start; i < end; i++)
            {
                if (A[i] <= pivot)
                {
                    k++;
                    Swap(A, i, k);
                }
            }
            Swap(A, end, k + 1);

            return k + 1;
        }

        static void Swap(int[] A, int start, int end)
        {
            int temp = A[start];
            A[start] = A[end];
            A[end] = temp;
        }

    }
}
