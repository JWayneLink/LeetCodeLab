using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLab.Medium
{
    public class AddTwoNumbers
    {
        /**
            * Definition for singly-linked list.
            * public class ListNode {
            *     public int val;
            *     public ListNode next;
            *     public ListNode(int val=0, ListNode next=null) {
            *         this.val = val;
            *         this.next = next;
            *     }
            * }
            */
        public ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            // 342 + 465 = 807
            int carry = 0;
            ListNode result = new ListNode(0);
            ListNode current = result;

            while (l1 != null || l2 != null || carry > 0)
            {
                if (l1 != null)
                {
                    carry = carry + l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    carry = carry + l2.val;
                    l2 = l2.next;
                }

                var n = carry % 10;
                current.next = new ListNode(n);

                //current.next = new ListNode(carry % 100 * 10);
                carry = carry / 10;
                current = current.next;
            }

            return result.next;
        }

        public List<int> addTwoNumbers(List<int> l1, List<int> l2)
        {
            string l1Char = string.Empty;
            foreach (var l1Item in l1.ToArray().Reverse())
            {
                l1Char += l1Item.ToString();
            }

            string l2Char = string.Empty;
            foreach (var l2Item in l2.ToArray().Reverse())
            {
                l2Char += l2Item.ToString();
            }

            string sumStr = (Convert.ToInt32(l1Char) + Convert.ToInt32(l2Char)).ToString();
            List<int> sumInt = new List<int>();
            foreach (char sumReversedChar in sumStr.ToCharArray().Reverse())
            {
                sumInt.Add(Convert.ToInt32(sumReversedChar.ToString()));
            }

            return sumInt;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
