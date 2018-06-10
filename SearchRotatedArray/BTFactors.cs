using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class BTFactors
    {
        public static int FindBTFactors(int[] A)
        {
            int MOD = 1000000007;
            Array.Sort(A);

            long[] dp = new long[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                dp[i] = 1;
            }

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; ++i)
            {
                dict.Add(A[i], i);
            }

            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    if (A[i] % A[j] == 0)
                    {
                        int right = A[i] / A[j];
                        if (dict.ContainsKey(right))
                        {
                            dp[i] = (dp[i] + dp[j] * dp[dict[right]]) % MOD;
                        }
                    }
                }

            }

            return (int)(dp.Sum() % MOD);
        }
    }
}
