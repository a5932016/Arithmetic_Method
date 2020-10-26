using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview
{
    /*
     * 印出所有組合 ex: A,B,C,D
     * 可以印出:A,B,AB,C,AC,BC,ABC,D,AD,BD,ABD,CD,ACD,BCD,ABCD
     */
    class Combinations
    {
        public static List<string[]> getAns(string[] arr)
        {
            List<string[]> list = new List<string[]>();
            foreach (string s in arr)
            {
                List<string[]> lst = list.GetRange(0, list.Count);
                string[] nArr = { s };
                list.Add(nArr);
                foreach (string[] ss in lst)
                {
                    list.Add(ss.Concat(nArr).ToArray());
                }
            }
            List<string[]> outList = list.OrderByDescending(p => p.Length).ToList();
            //outList.ForEach(p => Console.WriteLine(string.Join(",", p)));

            return list;
        }
    }
}
