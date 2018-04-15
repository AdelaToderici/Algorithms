using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    // https://www.educative.io/collection/page/5642554087309312/5679846214598656/10003/preview
    public class SmallestCommonNumber
    {
        public static int FindSmallestCommonNrInSortedArrays(int[] A, int[] B, int[] C)
        {
            int aMin = 0; int bMin = 0; int cMin = 0;
            while (aMin < A.Length || bMin < B.Length || cMin < C.Length)
            {
                if (A[aMin] == B[bMin] && A[aMin] == C[cMin])
                {
                    return A[aMin];
                }

                int min = Math.Min(Math.Min(A[aMin], B[bMin]), C[cMin]);

                if (min == A[aMin])
                {
                    aMin++;
                }

                if (min == B[bMin])
                {
                    bMin++;
                }

                if (min == C[cMin])
                {
                    cMin++;
                }
            }

            return -1;
        }
    }
}
