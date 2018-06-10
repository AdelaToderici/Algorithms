using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class StringDuplicates
    {
        public static string RemoveStringDuplicates(string input)
        {
            HashSet<char> set = new HashSet<char>();
            List<char> result = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!set.Contains(input[i]))
                {
                    set.Add(input[i]);
                    result.Add(input[i]);
                }
            }

            return String.Join("", result);
        }
    }
}
