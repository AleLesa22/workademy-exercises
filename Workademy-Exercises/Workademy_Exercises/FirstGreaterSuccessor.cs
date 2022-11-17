namespace Workademy_Exercises
{
    public class FirstGreaterSuccessor
    {
        private static int[] Test(int[] initialArray)
        {
            int resultIndexJ = 0;
            int resultIndexI = 0;

            int[] resultArray = new int[initialArray.Length];

            for (int i = 0; i < initialArray.Length; i++)
            {
                for (int j = i + 1; j < initialArray.Length; j++)
                {
                    if (initialArray[j] > initialArray[i])
                    {
                        resultIndexJ = j;
                        resultIndexI = i;

                        resultArray[i] = resultIndexJ - resultIndexI;
                        break;
                    }
                }
            }
            return resultArray;
        }
    }
}
