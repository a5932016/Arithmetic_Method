public class Pow
{
    public double MyPow(double x, int n)
    {
        if (x == 1 || n == 0)
            return 1;

        if (n == Int32.MinValue)
        {
            x = x * x;
            n = n / 2;
        }

        if (n < 0)
        {
            x = 1 / x;
            n = -n;
        }

        return Pows(x, n);
    }

    public double Pows(double x, int n)
    {
        double ans = 1;

        while (n > 0)
        {
            if ((n & 1) == 1)
                ans = ans * x;

            x = x * x;
            //ans=ans*x;
            n = n >> 1;
        }

        return ans;
    }
}