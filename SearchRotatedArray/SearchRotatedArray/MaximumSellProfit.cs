using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    // https://www.educative.io/collection/page/5642554087309312/5679846214598656/240001/preview
    public class MaximumSellProfit
    {
        public static int FindMaximumSellProfit(int[] A)
        {

            int min = int.MaxValue;
            int max = int.MinValue;
            int result = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                    continue;
                }

                if (A[i] > max)
                {
                    max = A[i];
                    if (max - min > result)
                    {
                        result = max - min;
                        max = int.MinValue;
                    }
                    
                }
            }

            return result;
        }
    }
}
