using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace _8FindWhichNumberIsNotPresentInSecondArray
{
    class FindMissingNumber
    {
        int[] ary1;
        Hashtable ht1 = new Hashtable();
        int ary1Max=0;
        int[] ary2;
        Hashtable ht2 = new Hashtable();

        public FindMissingNumber(string str1, string str2)
        {
            string[] temp;
            //Store the first array
            temp = str1.Split(',');
            ary1 = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                ary1[i] = Convert.ToInt32(temp[i]);
            }
            foreach (int x in ary1)
            {
                if (x > ary1Max)
                {
                    ary1Max = x;
                }
                ht1.Add(x, x);
            }
            //Store the second array
            temp = str2.Split(',');
            ary2 = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                ary2[i] = Convert.ToInt32(temp[i]);
            }
            foreach (int x in ary2)
            {
                ht2.Add(x, x);
            }

        }

        public string getResults()
        {
            string results = "";
            for (int i = 0; i <= ary1Max; i++)
            {
                if (ht1.Contains(i) && !ht2.Contains(i))
                {
                    results += i + " ";
                }
            }
            return results;
        }
    }
}
