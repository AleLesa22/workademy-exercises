namespace Workademy_Exercises
{
    public class ArrayIsContinuousSequence
    {
        public static bool Test(int[] arr)
        {
            bool IsDescending;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    if (arr[i] <= arr[i + 1])
                    {
                        IsDescending = true;
                        break;
                    }
                    else
                    {
                        IsDescending = false;
                        break;
                    }
                }
            }

            if (IsDescending = true)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] != arr[i + 1])
                    {
                        if (arr[i] < arr[i + 1])
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            if (IsDescending = false)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] != arr[i + 1])
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
