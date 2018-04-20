using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    // https://www.educative.io/collection/page/5642554087309312/5679846214598656/130003/preview
    class LowHighIndex
    {
        public static Tuple<int, int> FindLowHighIndexes(int[] A, int value)
        {
            int low = -1;
            int high = -1;

            int valueIndex = FindIndexIteratively(A, value);

            if (valueIndex == -1)
            {
                throw new Exception("Value not found.");
            }

            int midd = valueIndex;
            while (A[valueIndex] == value)
            {
                low = valueIndex;
                valueIndex--;
            }

            valueIndex = midd;
            while (A[valueIndex] == value)
            {
                high = valueIndex;
                valueIndex++;
            }

            return Tuple.Create<int, int>(low, high);

        }

        private static int FindIndexRecursively(int[] A, int start, int end, int value)
        {
            if (A[start] == value)
            {
                return start;
            }

            if (A[end] == value)
            {
                return end;
            }

            int midd = start + ((end - start) / 2);

            if (A[midd] == value)
            {
                return midd;
            }

            return FindIndexRecursively(A, start, end, value);
        }

        private static int FindIndexIteratively(int[] A, int value)
        {
            int start = 0;
            int end = A.Length - 1;
            int midd = start + ((end - start) / 2);

            while (A[midd] != value)
            {
                if (start == end && A[start] != value)
                {
                    return -1;
                } 

                if (A[midd] > value)
                {
                    end = midd - 1;
                }
                else
                {
                    start = midd + 1;
                }
                 midd = (start + end) / 2;
            }

            return midd;
        }
    }
}
