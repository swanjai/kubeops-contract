using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace a03
{
    public class BalanceBook
    {
        public void Balance(Dictionary<string, decimal> memberDict)
        {
            var averageScore = memberDict.Values.Average();
            Console.WriteLine("=====> Average = " + averageScore);
            Dictionary<string, decimal> changeDict = new Dictionary<string, decimal>();

            foreach (KeyValuePair<string, decimal> kvp in memberDict)
            {
                var name = kvp.Key;
                var change = Math.Round((kvp.Value - averageScore), 2);
                changeDict.Add(name, change);
            }

            Console.WriteLine("===== Name & Change =====");
            foreach (KeyValuePair<string, decimal> kvp in changeDict)
            {
                Console.WriteLine("{0} : {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("===== END =====");
        }
    }
}
