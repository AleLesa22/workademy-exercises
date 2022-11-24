using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workademy_Exercises
{
    public class SuperElementOfArray
    {
        public static int Test(int[] arr)
        {
            int SuperElement = -1;
            List<int> listOfElements = new List<int>();
            foreach (int element in arr)
            {
                listOfElements.Add(element);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == listOfElements.Select(x => x).Where(x => x == arr[i]).Count())
                {
                    if (arr[i] > SuperElement)
                    {
                        SuperElement = arr[i];
                    }
                }
            }
            return SuperElement;
        }
    }
}
