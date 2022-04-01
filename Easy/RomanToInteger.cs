using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLab.Easy
{
    public class RomanToInteger
    {

        /*
            I can be placed before V (5) and X (10) to make 4 and 9. 
            X can be placed before L (50) and C (100) to make 40 and 90. 
            C can be placed before D (500) and M (1000) to make 400 and 900.
         */

        public int SubCount(string preChar, string postChar)
        {
            int pre = romanIntDIc.Where(x => x.Key.Equals(preChar)).Select(x => x.Value).FirstOrDefault();
            int post = romanIntDIc.Where(x => x.Key.Equals(postChar)).Select(x => x.Value).FirstOrDefault();
            int tmp = post - pre;
            return tmp;
        }

        public Dictionary<string, int> romanIntDIc { get; set; }
        public RomanToInteger()
        {
            romanIntDIc = new Dictionary<string, int>();
            romanIntDIc.Add("I", 1); // 1
            romanIntDIc.Add("V", 5);
            romanIntDIc.Add("X", 10); // 10
            romanIntDIc.Add("L", 50);
            romanIntDIc.Add("C", 100); // 100
            romanIntDIc.Add("D", 500);
            romanIntDIc.Add("M", 1000); // 1000
        }

        public int RomanToInt(string s)
        {
            int resultInt = 0;
            char[] values = s.ToCharArray();
            for (int i = 0; i < values.Length; i++)
            {
                string v = values[i].ToString();

                if (v.Equals("I") || v.Equals("X") || v.Equals("C"))
                {
                    if (i < values.Length - 1)
                    {
                        string next = values[i + 1].ToString();
                        if ((v.Equals("I") && next.Equals("V")) || (v.Equals("I") && next.Equals("X")))
                        {
                            resultInt += this.SubCount(v, next);
                            i = ++i;
                        }
                        else if ((v.Equals("X") && next.Equals("L")) || (v.Equals("X") && next.Equals("C")))
                        {
                            resultInt += this.SubCount(v, next);
                            i = ++i;
                        }
                        else if ((v.Equals("C") && next.Equals("D")) || (v.Equals("C") && next.Equals("M")))
                        {
                            resultInt += this.SubCount(v, next);
                            i = ++i;
                        }
                        else
                        {
                            resultInt += romanIntDIc.Where(x => x.Key.Equals(v)).Select(x => x.Value).FirstOrDefault();
                        }
                    }
                    else
                    {
                        resultInt += romanIntDIc.Where(x => x.Key.Equals(v)).Select(x => x.Value).FirstOrDefault();
                    }
                }
                else
                {
                    resultInt += romanIntDIc.Where(x => x.Key.Equals(v)).Select(x => x.Value).FirstOrDefault();
                }
            }
            return resultInt;
        }
    }
}
