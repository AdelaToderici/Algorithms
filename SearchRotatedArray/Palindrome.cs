using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedArray
{
    class Palindrome
    {
        public static string FindPalindromeSubstrings(string input)
        {
            string palindrome = null;
            bool[,] T = new bool[input.Length, input.Length];
            int maxLenght = 0;

            for (int i = 0; i < input.Length; i++)
            {
                T[i, i] = true;
            }

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i+1])
                {
                    T[i, i + 1] = true;
                    palindrome += input.Substring(i, 2) + " "; // to be edited
                    maxLenght = 2;
                }
            }

            for (int k = 3; k <= input.Length; k++)
            {
                for (int i = 0; i < input.Length - k + 1; i++)
                {
                    int j = i + k - 1;

                    if (T[i+1, j-1] == true && input[i] == input[j])
                    {
                        T[i, j] = true;
                        if (k > maxLenght)
                        {
                            palindrome += input.Substring(i, k) + " ";
                            maxLenght = k;
                        }
                    }
                }
            }

            return palindrome;
        }
    }
}
