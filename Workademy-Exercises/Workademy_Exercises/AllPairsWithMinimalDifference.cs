using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workademy_Exercises
{
    public class AllPairsWithMinimalDifference
    {
        public static IList<int[,]> Test(int[] arr)
        {
            int minAbsDiff = int.MaxValue;
            int newMinAbsDiff;
            int[,] helpingArr;
            IList<int[,]> IResultArr = new List<int[,]>();


            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                newMinAbsDiff = arr[i + 1] - arr[i];
                if (newMinAbsDiff < 0)
                {
                    newMinAbsDiff = newMinAbsDiff * (-1);
                }
                if (newMinAbsDiff < minAbsDiff)
                {
                    minAbsDiff = newMinAbsDiff;
                }
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] - arr[i] == minAbsDiff)
                {
                    helpingArr = new int[1, 2];
                    helpingArr[0, 0] = arr[i];
                    helpingArr[0, 1] = arr[i + 1];
                    IResultArr.Add(helpingArr);
                }
            }
            return IResultArr;
        }
    }
}
