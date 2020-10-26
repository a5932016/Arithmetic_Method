using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            var ans1 = string.Join("\r\n", CalcuateMerchandiseValue.getAns("COMPUTER 2 1000; MEMORY 3 5000").AsEnumerable().Select(p => p).ToArray());
            Console.WriteLine(ans1);

            var ans2 = "2 3 + 1 + 2 - 3 =";
            Console.WriteLine(ans2 + CalculateFormula.getAns(ans2));

            string[] ans3 = new string[] { "A", "B", "C", "D" };
            Combinations.getAns(ans3).ForEach(p => Console.WriteLine(string.Join(",", p)));

            int[] ans4 = new int[] { 3, 17 };
            FindPrimes.getAns(ans4[0], ans4[1]).ForEach(p => Console.WriteLine(p));

            int[] ans5 = new int[] { 12, 8, 20, 24 };
            Console.WriteLine(Gcd.getAns(ans5));

            string ans6 = "234";
            Console.WriteLine(LetterCombinationsOfAPhoneNumber.getAns(ans6));

            // 只保留英文字母
            string asd = "Asd123g3$#".ToLower();
            asd = System.Text.RegularExpressions.Regex.Replace(asd, @"[^a-z]*", "");
        }
    }
}
