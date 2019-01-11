using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_parity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a 7-bit binary number:");
            string x = Console.ReadLine();
            int count0 = 0;
            int count1 = 0;

            for (int i = 0; i < x.Length; i++) 
            {
                if (x.Substring(i, 1) == "0")
                {
                    count0++;
                }

                else if (x.Substring(i, 1) == "1")
                {
                    count1++;
                }
            
                else
                {
                    Console.WriteLine("You did not enter a valid 7-bit binary number");
                }
            }
        }
    }
}
