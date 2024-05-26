namespace PowerTester
{
    public class Power
    {
        // 
        public static double CalculatePower(double x, int n)
        {
            if (n == 0)
            {
                return 1.0;
            }
            else if (n > 0)
            {
                return x * CalculatePower(x, n - 1);
            }
            else
            {
                return CalculatePower(x, n + 1) / x;
            }
        }
    }
}