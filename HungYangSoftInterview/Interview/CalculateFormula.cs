using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Interview
{
    /*
     * 計算一行算式，只有加減乘除，計算等號左邊的算式，但算是中間有空白
     * 因為沒有其他運算符號的關係，故這題不用將中綴表達式轉換為後綴表達式，直接利用Queue計算即可
     * input "2 3 + 1 + 2 - 3 =" output 23
     */
    class CalculateFormula
    {
        public static int getAns(string args)
        {
            int result = 0;
            var arg = args.Split(" ");
            string prev = string.Empty;

            foreach (var i in arg)
            {
                if (prev.Trim() == string.Empty || isInt(i) == 0)
                {
                    prev = i;
                    continue;
                }

                result = factory(new object[] { result, prev, i });
                prev = i;
            }

            return result;
        }

        private static int factory(object[] args)
        {
            if (args.Length < 3)
                throw new Exception("factory參數不足");

            int result = Convert.ToInt32(args[0]);

            switch (args[1].ToString().Trim())
            {
                case "+":
                    result = Convert.ToInt32(args[0]) + Convert.ToInt32(args[2]);
                    break;
                case "-":
                    result = Convert.ToInt32(args[0]) - Convert.ToInt32(args[2]);
                    break;
                case "*":
                    result = Convert.ToInt32(args[0]) * Convert.ToInt32(args[2]);
                    break;
                case "/":
                    result = Convert.ToInt32(args[0]) / Convert.ToInt32(args[2]);
                    break;
                case "=":
                    break;
                default:
                    result = Convert.ToInt32(args[0]) + (Convert.ToInt32(args[1]) * 10) + Convert.ToInt32(args[2]);
                    break;
            }

            return result;
        }

        private static int isInt(string arg)
        {
            int result = 0;

            int.TryParse(arg, out result);

            return result;
        }
    }
}
