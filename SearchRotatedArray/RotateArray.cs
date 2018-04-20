using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    // https://www.educative.io/collection/page/5642554087309312/5679846214598656/210003/preview
    class RotateArray
    {
        public static int[] RotateGivenArray(int[] A, int k)
        {
            int j = A.Length - k;
            for (int i = 0; i < A.Length; i++)
            {
                if (A.Length - i > k)
                {
                    if (j == A.Length)
                    {
                        j = A.Length - k;
                    }

                    int temp = A[j];
                    A[j] = A[i];
                    A[i] = temp;

                    j++;
                }
                else
                {
                    int temp = A[A.Length - 1];
                    A[A.Length - 1] = A[i];
                    A[i] = temp;
                }
            }

            return A;
        }
    }
}
