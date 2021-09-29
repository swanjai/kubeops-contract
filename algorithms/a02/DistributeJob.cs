using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace a02
{
    public class DistributeJob
    {
        public static void Distribute(int nServer, int nJob)
        {
            int equalJob = nJob/nServer;
            int noOwnerJob = nJob%nServer;
            List<int> serverJobList = new List<int>();
            //List<int[]> distributeJobList = new List<int[]>();

            for (int i = 0; i < nServer; i++)
            {
                if (i < noOwnerJob)
                {
                    serverJobList.Add(equalJob + 1);
                }
                else
                {
                    serverJobList.Add(equalJob);
                }                
            }

            int j = 0;
            Console.WriteLine("===== Server & Job =====");
            for (int i = 0; i < serverJobList.Count; i++)
            {                
                int[] arr = new int[serverJobList[i]];
                for (int k = 0; k < arr.Length; k++)
                {
                    arr[k] = j;
                    j++;
                }

                Console.WriteLine("Server " + (i+1) + " (" + arr.Length + ")" + " : " + String.Join(",", arr));
                //distributeJobList.Add(arr);
            }
            Console.WriteLine("===== END =====");
        }
    }
}
