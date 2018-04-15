using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    //https://www.educative.io/collection/page/5642554087309312/5679846214598656/180002/preview
    public class ZerosToLeft
    {
        public static int[] MoveZerosToLeft(int[] A)
        {
            int j = A.Length - 1;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[j] != 0)
                {
                    j--;
                    continue;
                }

                if (A[i] != 0 && j >= 0)
                {
                    int temp = A[j];
                    A[j] = A[i];
                    A[i] = temp;
                    j--;
                }
            }

            return A;
        }
    }
}
