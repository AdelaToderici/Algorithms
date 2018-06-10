using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class ReverseWords
    {
        public static string ReverseWordsInSentence(string input)
        { 
            var array = input.Split(' ').Reverse();
            string result = string.Join(" ", array);
            
            return result;
        }
    }
}
