using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workademy_Exercises
{
    public class UglyNumberCheck
    {
        public static bool Test(int num)
        {
            if (num < 0)
            {
                return false;
            }
            if (num == 1)
            {
                return true;
            }

            while (num != 1)
            {
                if (num % 2 == 0)
                {
                    while (num % 2 == 0)
                    {
                        num = num / 2;
                        if (num == 1)
                        {
                            return true;
                        }
                    }
                }
                else if (num % 3 == 0)
                {
                    while (num % 3 == 0)
                    {
                        num = num / 3;
                        if (num == 1)
                        {
                            return true;
                        }
                    }
                }
                else if (num % 5 == 0)
                {
                    if (num % 5 == 0)
                    {
                        while (num % 5 == 0)
                        {
                            num = num / 5;
                            if (num == 1)
                            {
                                return true;
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
