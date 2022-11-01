internal class Program
{
    //Write a method that recives one integer positive number and returns true
    //if number has the same value if it is read from right to left, otherwise it returns false
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
    private static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        IsReadable(num);

        string boolOutput = IsReadable(num).ToString();
        Console.WriteLine(boolOutput);

        Console.ReadLine();
    }
}