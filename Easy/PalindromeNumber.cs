using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLab.Easy
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {           
            var len = x.ToString().Length;
            string prefix = string.Empty;
            string middle = string.Empty;
            string suffix = string.Empty;
            for (int i = 0; i < x.ToString().ToCharArray().Length; i++)
            {
                if (i < len / 2)
                {
                    prefix += x.ToString().ToCharArray()[i];
                }
                else if (i > len / 2)
                {
                    suffix += x.ToString().ToCharArray()[i];
                }
                else
                {
                    middle += x.ToString().ToCharArray()[i];
                }
            }

            Console.WriteLine(prefix + middle + suffix);

            string reversedSuffix = string.Empty;
            if (len % 2 != 0)
            {
                foreach (var item in suffix.ToCharArray().Reverse().ToList())
                {
                    reversedSuffix += item.ToString();
                }

                return prefix.Equals(reversedSuffix);
            }
            else
            {
                suffix = middle + suffix;
                foreach (var item in suffix.ToCharArray().Reverse().ToList())
                {
                    reversedSuffix += item.ToString();
                }
                return prefix.Equals(reversedSuffix);
            }            
        }
    }
}
