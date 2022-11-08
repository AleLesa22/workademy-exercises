using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workademy_Exercises
{
    public class GreatestCommonDivisorOfArray
    {
        //7TH NOVEMBER
        public static int Test(int[] arr)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int output = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            for (int j = max; j >= 1; j--)
            {
                if (min % j == 0 && max % j == 0)
                {
                    output = j;
                    break;
                }
            }
            return output;
        }
    }
}
