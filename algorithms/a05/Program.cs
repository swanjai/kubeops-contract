using System;

namespace a05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter string.");
                string s = Console.ReadLine();
                Console.WriteLine("IsPalindrome : " + IsPalindrome.Check(s));
            }
            catch (System.Exception)
            {                
                throw;
            }
            
        }
    }
}
