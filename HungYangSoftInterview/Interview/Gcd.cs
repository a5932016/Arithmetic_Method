using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview
{
    /*
     * 找到n個數的最大公因數
     * 
     * 最大公因數（英語：highest common factor，hcf）也稱最大公約數（英語：greatest common divisor，gcd）
     * 是數學詞彙，指能夠整除多個整數的最大正整數。 而多個整數不能都為零。 例如8和12的最大公因數為4。
     */
    class Gcd
    {
        private static int[] getFactor(int[] args)
        {
            if (args.Length < 2)
                throw new Exception("參數錯誤");

            var tmp = args.OrderByDescending(p => p).ToArray();
            return new int[] { tmp[0] % tmp[1], tmp[1] };
        }

        public static int getAns(int[] args)
        {
            int[] result = new int[2] { 0, 0 };
            var tmp = args.OrderByDescending(p => p);

            foreach (int arg in tmp)
            {
                if (result[0] == 0)
                {
                    result[0] = arg;
                    continue;
                }

                do
                {
                    result = getFactor(new int[] { result[0], arg });
                } while (result[0] != 0);

                result[0] = result[1];
            }

            return result[1];
        }
    }
}
