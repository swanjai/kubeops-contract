using System;

namespace a04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number");
            int n = int.Parse(Console.ReadLine());     
            Console.WriteLine(Fibonacci.Get(n));
        }
    }
}
