using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workademy_Exercises
{
    public class CheckIfStringIsSubsequenceOfSentence
    {
        //4th NOVEMBER
        public static bool Test(string firstString, string secondString)
        {
            HashSet<char> HashsetOne = new HashSet<char>();
            HashSet<char> HashsetTwo = new HashSet<char>();

            foreach (char c in secondString)
            {
                HashsetTwo.Add(c);
            }

            foreach (char c in firstString)
            {
                HashsetOne.Add(c);
                if (HashsetTwo.Contains(c))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
