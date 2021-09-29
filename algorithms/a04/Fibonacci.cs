using System;

namespace a04
{
    public class Fibonacci
    {  
        public static int Get(int n)
        {
            double phi = (1 + Math.Sqrt(5)) / 2;
            return (int) Math.Round(Math.Pow(phi, n) / Math.Sqrt(5));
        }
    }
}
