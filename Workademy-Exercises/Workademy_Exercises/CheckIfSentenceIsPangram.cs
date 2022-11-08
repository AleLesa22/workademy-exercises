using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workademy_Exercises
{
    public class CheckIfSentenceIsPangram
    {
        //3rd NOVEMBER
        public static bool Test(string str)
        {
            HashSet<char> Hashset = new HashSet<char>();
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            foreach (char c in str)
            {
                Hashset.Add(c);
            }
            if (alphabet.Length == Hashset.Count)
            {
                return true;
            }
            return false;
        }
    }
}
