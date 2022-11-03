internal class Program
{
    //Write a method that recives one integer positive number and returns true
    //if number has the same value if it is read from right to left, otherwise it returns false
    
    //1st NOVEMBER
    public static bool IsReadable(int num)
    {
        int initialNum = num;
        int reverse = 0;
        int step;

        if(num < 0)
        {
            return false;
        }

        while (num != 0)
        {
            step = num % 10;
            reverse = reverse * 10 + step;
            num = num / 10;
        }
        if(initialNum == reverse)
        {
            return true;
        }
        return false;
    }
    //2nd NOVEMBER
    public static int NumberOfPerfectStrings(string str)
    {
        int countY = 0;
        int PerfectSubString = 0;
        if (str.StartsWith("R"))
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == "R")
                {
                    countY++;
                    if (str[i + 1].ToString() == "S")
                    {
                        countY--;
                        i++;
                        if (countY == 0)
                        {
                            PerfectSubString++;
                        }
                    }
                }
                else if (str[i].ToString() == "S")
                {
                    countY--;
                    if (countY == 0)
                    {
                        PerfectSubString++;
                    }
                }
            }
        }
        if(str.StartsWith("S"))
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == "S")
                {
                    countY++;
                    if (str[i + 1].ToString() == "R")
                    {
                        countY--;
                        i++;
                        if (countY == 0)
                        {
                            PerfectSubString++;
                        }
                    }
                }
                else if (str[i].ToString() == "R")
                {
                    countY--;
                    if (countY == 0)
                    {
                        PerfectSubString++;
                    }
                }
            }
        }
            return PerfectSubString;

            
    }
    private static void Main(string[] args)
    {
        //1st NOVEMBER
        //int num = Convert.ToInt32(Console.ReadLine());
        //IsReadable(num);

        //string boolOutput = IsReadable(num).ToString();
        //Console.WriteLine(boolOutput);

        //Console.ReadLine();

        //2nd NOVEMBER
        string str = "RSRRSSRSRS";
        Console.WriteLine(NumberOfPerfectStrings(str));
        Console.ReadLine();
    }
}