using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
    /*
     * 找到m~n範圍內的所有質數
     */
    class FindPrimes
    {
        private static bool isPrimeNumber(int arg)
        {
            bool result = true;

            for (int i = 2; i < arg; i++)
            {
                if (arg % i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public static List<int> getAns(int start,int end)
        {
            List<int> result = new List<int>();

            for (; start < end; start++)
            {
                if (!isPrimeNumber(start))
                    continue;

                result.Add(start);
            }

            return result;
        }
    }
}
