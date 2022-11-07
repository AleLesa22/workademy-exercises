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
    //2nd NOVEMBER
    public static int NumberOfPerfectStrings(string str)
    {
        int count = 0;
        int PerfectSubString = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i].ToString() == "R")
            {
                count++;
                if (count == 0)
                {
                    PerfectSubString++;
                }
            }
            else if (str[i].ToString() == "S")
            {
                count--;
                if (count == 0)
                {
                    PerfectSubString++;
                }
            }
        }
        return PerfectSubString;
    }

    //3rd NOVEMBER
    public static bool IsStringPangram(string str)
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

    public static bool IsFristStringSubsequenceOfSecond(string firstString, string secondString)
    {
        HashSet<char> HashsetOne = new HashSet<char>();
        HashSet<char> HashsetTwo = new HashSet<char>();

        foreach(char c in secondString)
        {
            HashsetTwo.Add(c);
        }

        foreach(char c in firstString)
        {
            HashsetOne.Add(c);
            if(HashsetTwo.Contains(c))
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
    private static void Main(string[] args)
    {
        //1st NOVEMBER
        //int num = Convert.ToInt32(Console.ReadLine());
        //IsReadable(num);

        //string boolOutput = IsReadable(num).ToString();
        //Console.WriteLine(boolOutput);

        //Console.ReadLine();

        //2nd NOVEMBER
        //string str = "RSRRSSRSRS";
        //Console.WriteLine(NumberOfPerfectStrings(str));
        //Console.ReadLine();

        //3rd NOVEMBER
        //string str = "jackamazedafewgirlsbydroppingtheantiqueonyxvas";
        //Console.WriteLine(IsStringPangram(str));
        //Console.ReadLine();

        //4th NOVEMBER
        string firstString = "abc";
        string secondString = "ahbgdc";
        Console.WriteLine(IsFristStringSubsequenceOfSecond(firstString, secondString));
        Console.ReadLine();

    }
}