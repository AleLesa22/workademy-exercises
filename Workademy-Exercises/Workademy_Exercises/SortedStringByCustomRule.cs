using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workademy_Exercises
{
    public class SortedStringByCustomRule
    {
        public static string Test(string inputString, string outputString)
        {
            HashSet<char> inputHashset = new HashSet<char>();
            HashSet<char> outputHashset = new HashSet<char>();
            HashSet<char> orderedHashset = new HashSet<char>();
            string orderedStringResult;


            foreach (char c in inputString)
            {
                inputHashset.Add(c);
            }

            foreach (char c in outputString)
            {
                outputHashset.Add(c);
            }

            foreach (char c in inputString)
            {
                if (outputString.Contains(c))
                {
                    orderedHashset.Add(c);
                }
            }

            foreach (char c in outputString)
            {
                if (!inputString.Contains(c))
                {
                    orderedHashset.Add(c);
                }
            }

            orderedStringResult = string.Join("", orderedHashset);
            return orderedStringResult;
        }
    }
}
