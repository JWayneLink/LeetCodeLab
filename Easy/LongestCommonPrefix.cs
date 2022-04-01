using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLab.Easy
{
    public class LongestCommonPrefix
    {
        public string GetLongestCommonPrefix(string[] strs)
        {
            // "flower", "flow", "flight"
            int itemIndex = 0;
            int charIndex = 0;
            bool isSame = true;
            string prefix = string.Empty;
            string prefixNext = string.Empty;
            while (isSame)
            {
                string item = strs[itemIndex];

                if (string.IsNullOrEmpty(item))
                {
                    break;
                }
                if (itemIndex == 0)
                {
                    prefix = item.ToCharArray()[charIndex].ToString();
                    isSame = true;

                }
                else
                {
                    prefixNext = item.ToCharArray()[charIndex].ToString();
                }

                ++itemIndex;

                if (itemIndex > 1 && !prefix.Equals(prefixNext))
                {
                    isSame = false;                    
                }
                else
                {
                    if (itemIndex == strs.Length)
                    {
                        if (charIndex == item.Length -1)
                        {
                            break;
                        }
                        else
                        {
                            ++charIndex;
                            itemIndex = 0;
                        }                        
                    }
                }

                //Console.WriteLine(prefix);
                //Console.WriteLine(prefixNext);
            }

            string s = string.Empty;
            if (strs.Length == 1)
            {
                return prefix;
            }
            for (int i = 0; i < charIndex; i++)
            {
                s += strs[0].ToCharArray()[i].ToString();
            }
            Console.WriteLine(s);
            return s;
        }
    }
}
