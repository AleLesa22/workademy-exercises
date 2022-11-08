using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workademy_Exercises
{
    public class CheckIfNumberIsPalindrome
    {
        //1st NOVEMBER
        public static bool Test(int num)
        {
            int initialNum = num;
            int reverse = 0;
            int step;

            if (num < 0)
            {
                return false;
            }

            while (num != 0)
            {
                step = num % 10;
                reverse = reverse * 10 + step;
                num = num / 10;
            }
            if (initialNum == reverse)
            {
                return true;
            }
            return false;
        }

    }
}
