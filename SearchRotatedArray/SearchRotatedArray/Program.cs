using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class Program
    {
        // https://www.educative.io/collection/page/5642554087309312/5679846214598656/100002/preview
        static int FindElemInRotatedArray(int[] A, int k, int start, int end)
        {
            if (A[start] == k)
            {
                return start;
            }
            if (A[end] == k)
            {
                return end;
            }

            if (A[start] > k)
            {
                int midd = start + ((end - start) / 2);
                if (A[midd] == k)
                {
                    return midd;
                }
                if (A[midd] > k && A[midd] < A[start])
                {
                    return FindElemInRotatedArray(A, k, start, midd - 1);
                }
                return FindElemInRotatedArray(A, k, midd + 1, end);
            }
            else
            {
                int midd = start + ((end - start) / 2);
                if (A[midd] == k)
                {
                    return midd;
                }
                if (A[midd] < A[start])
                {
                    return FindElemInRotatedArray(A, k, start + 1, midd - 1);
                }
                if (A[midd] > k)
                {
                    return FindElemInRotatedArray(A, k, start, midd - 1);
                }
                return FindElemInRotatedArray(A, k, midd + 1, end);
            }
        }

        static void Main(string[] args)
        {
            //int[] A = new int[] { 7, 4, 2, 5, 9, 11, 6, 8, 3 };
            //int[] A = new int[] { 7, 4, 10, 3, 2, 5, 9, 1, 11, 6, 8, -1 };
            //MaxSlidingWindow.FindMaxElementInWindow(A, 5);

            // int[] A = new int[] { 15, 22, 34, 38, 48 };
            // int[] B = new int[] { 27, 39, 48, 50, 56 };
            // int[] C = new int[] { 20, 29, 33, 48, 50 };
            //
            // int result = SmallestNrSortedArrays.FindSmallestCommonNrInSortedArrays(A, B, C);
            // Console.Write(result);
            //
            // Console.Read();

            //   int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //   var result = RotateArray.RotateGivenArray(A, 3);
            //   Console.WriteLine(String.Join(", ", result));
            //   Console.Read();

            //    int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 7, 7, 7, 7, 7, 7, 8, 9, 10 };
            //    var result = LowHighIndex.FindLowHighIndexes(A, 7);
            //    Console.WriteLine(String.Join(", ", result));
            //    Console.Read();

            /* int result = FindElemInRotatedArray(A, 8, 0, A.Length - 1);
            Console.Write(result); */

            //   int[] A = new int[] { 2, 3, 0, 4, 7, 0, 9, 10, 0, 11 };
            //   var result = ZerosToLeft.MoveZerosToLeft(A);
            //   Console.Write(String.Join(", ", result));
            //   Console.Read();

         //   int[] A = new int[] { 7, 2, 4, 14, 1, 9, 5, 14 };
         //   var result = MaximumSellProfit.FindMaximumSellProfit(A);
         //   Console.Write(result);
         //   Console.Read();

        }
    }
}
