using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Interview
{
    /*
     * 找到手機按鍵輸入的所有組合，類似LeetCode的第17題
     * https://leetcode.com/problems/letter-combinations-of-a-phone-number/description/
     */

    class LetterCombinationsOfAPhoneNumber
    {
        public static List<string> getAns(string digits)
        {
            List<string> ans = new List<string>();

            if (digits == null || digits.Length == 0) 
                return ans;

            char[][] map = new char[8][];
            map[0] = "abc".ToArray();
            map[1] = "def".ToArray();
            map[2] = "ghi".ToArray();
            map[3] = "jkl".ToArray();
            map[4] = "mno".ToArray();
            map[5] = "pqrs".ToArray();
            map[6] = "tuv".ToArray();
            map[7] = "wxyz".ToArray();

            char[] input = digits.ToArray();
            ans.Add("");
            foreach (char c in input)
                ans = expand(ans, map[Convert.ToInt32(c.ToString())]); // c - '2'
            return ans;
        }

        private static List<string> expand(List<string> l, char[] arr)
        {
            List<string> next = new List<string>();
            foreach (string s in l)
                foreach (char c in arr)
                    next.Add(s + c);
            return next;
        }
    }
}
