using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class UniqueBST
    {
        static Dictionary<int, int> dict = new Dictionary<int, int>();

        public static int UniqueBSTCount(int n)
        {
            if (dict.ContainsKey(n)) { return dict[n]; }

            if (n <= 0 || n == 1) { return 1; }

            if (n == 2) { return 2; }

            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += CurrentSum(n, i);
            }

            dict.Add(n, result);

            return result;
        }

        private static int CurrentSum(int n, int k)
        {
            return UniqueBSTCount(k - 1) * UniqueBSTCount(n - k);
        }
    }
}
