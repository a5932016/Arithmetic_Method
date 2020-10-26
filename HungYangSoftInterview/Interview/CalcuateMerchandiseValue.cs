using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview
{
	/* 名字	數量 單價
     * "COMPUTER 2 1000; MEMORY 3 5000"
     * 
     * 輸出: 名字 總價 均價
     * "COMPUTER 2000 1000"
     * "MEMORY 15000 5000"
     */
	class CalcuateMerchandiseValue
    {
        public static List<string> getAns(string args)
        {
            List<string> result = new List<string>();
            string[] ls = new string[3];
            var arg = args.Split(";");
            int inx = 0;

            foreach (string i in arg)
            {
                inx = 0;
                if (i.Trim() == string.Empty)
                    continue;

                var argSplit = i.Split(" ");
                foreach (string j in argSplit)
                {
                    if (j.Trim() == string.Empty)
                        continue;
                    ls[inx++] = j;
                }

                result.Add(string.Format("{0} {1} {2}", ls[0], Convert.ToInt32(ls[1]) * Convert.ToInt32(ls[2]), ls[2]));
            }

            return result;
        }
    }
}
