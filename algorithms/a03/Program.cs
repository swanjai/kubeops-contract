using System;
using System.Collections;
using System.Collections.Generic;

namespace a03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the number of people.");
                int n = int.Parse(Console.ReadLine());
                Dictionary<string, decimal> memberDict = new Dictionary<string, decimal>();

                Console.WriteLine("Enter name and spend");
                for (int i = 0; i < n; i++)
                {                    
                    Console.WriteLine((i+1) + ".Name :");
                    string name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine((i+1) +".Spend :");
                    decimal spend = Math.Round(Decimal.Parse(Console.ReadLine()), 2);
                    memberDict.Add(name, spend);
                }

                Console.WriteLine("===== Name & Spend =====");
                foreach (KeyValuePair<string, decimal> kvp in memberDict)
                {
                    Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
                }
                
                BalanceBook balanceBook = new BalanceBook();
                balanceBook.Balance(memberDict);
            }
            catch (System.Exception)
            {                
                throw;
            }
        }
    }
}
