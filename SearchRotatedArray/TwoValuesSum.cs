using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class TwoValuesSum
    {
        public static Tuple<int, int> FindTwoValuesForSum(int[] A, int sum)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (!set.Contains(sum - A[i]))
                {
                    set.Add(A[i]);
                }
                else
                {
                    return Tuple.Create<int, int>(A[i], (sum - A[i]));
                }
            }

            return default(Tuple<int, int>);
        }
    }
}
