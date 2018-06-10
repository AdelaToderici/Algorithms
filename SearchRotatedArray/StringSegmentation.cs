using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class StringSegmentation
    {
        public static bool FindInputInDict(Dictionary<int, string> dict, string input)
        {
            string result = null;
            int counter = 0;

            while (input.Length > 0)
            {
                for (int i = 0; i < dict.Count; i++)
                {
                    if (input.Contains(dict[i]))
                    {
                        result += dict[i] + " ";
                        input = input.Replace(dict[i], "");
                        counter = 0;
                        break;
                    }
                    else
                    {
                        counter++;
                    }
                }

                if (counter == dict.Count)
                {
                    return false;
                }
                
            }

            return true;
        }
    }
}
