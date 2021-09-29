using System;

namespace a02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the number of servers.");
                int nServer = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the number of jobs.");
                int nJob = int.Parse(Console.ReadLine());

                DistributeJob.Distribute(nServer, nJob);
            }
            catch (System.Exception)
            {                
                throw;
            }
        }
    }
}
