using LeetCodeLab.Easy;
using LeetCodeLab.Medium;
using System;
using System.Collections.Generic;


namespace LeetCodeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddTwoNumbers addTwoNumbers = new AddTwoNumbers();
            //ListNode sumInt = addTwoNumbers.addTwoNumbers(new ListNode(342), new ListNode(465));


            PalindromeNumber palindromeNumber = new PalindromeNumber();
            //bool isPalindome = palindromeNumber.IsPalindrome(1221);

            //RomanToInteger romanToInteger = new RomanToInteger();
            //romanToInteger.RomanToInt("LVIII");
            //romanToInteger.RomanToInt("MCMXCIV");
            //romanToInteger.RomanToInt("III");
            //romanToInteger.RomanToInt("IV");

            LongestCommonPrefix longestCommonPrefix = new LongestCommonPrefix();
            //longestCommonPrefix.GetLongestCommonPrefix(new string[] { "flower", "flow", "flight" });
            longestCommonPrefix.GetLongestCommonPrefix(new string[] { "a" });
            //longestCommonPrefix.GetLongestCommonPrefix(new string[] { "" });
            //longestCommonPrefix.GetLongestCommonPrefix(new string[] { "dog", "racecar", "car" });




            Console.ReadKey();
        }
    }
}
