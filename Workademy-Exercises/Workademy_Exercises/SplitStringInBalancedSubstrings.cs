using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workademy_Exercises
{
    public class SplitStringInBalancedSubstrings
    {
        //2nd NOVEMBER
        public static int Test(string str)
        {
            int count = 0;
            int PerfectSubString = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == "R")
                {
                    count++;
                    if (count == 0)
                    {
                        PerfectSubString++;
                    }
                }
                else if (str[i].ToString() == "S")
                {
                    count--;
                    if (count == 0)
                    {
                        PerfectSubString++;
                    }
                }
            }
            return PerfectSubString;
        }

    }
}
