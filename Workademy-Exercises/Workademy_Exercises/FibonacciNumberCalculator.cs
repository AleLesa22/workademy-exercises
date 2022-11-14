namespace Workademy_Exercises
{
    public class FibonacciNumberCalculator
    {
        public static int Test(int n)
        {
            int result = 0;
            if (n == 0)
            {
                return 0;
            }
            if (n > 2)
            {
                result = Test(n - 2) + Test(n - 1);
            }
            else
            {
                result = 1;
            }
            return result;
        }
    }
}
