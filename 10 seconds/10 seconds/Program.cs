using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Hit the 'Enter' key when you think 10 seconds have passed!");
            string ten = Console.ReadLine();
            DateTime starttime = DateTime.Now;
            TimeSpan ts = (starttime - today);
            double answer = (10 - (Math.Round(ts.TotalSeconds)));
            if (answer == 0)
            {
                Console.WriteLine("Congratulations, you managed to press 'Enter' on 10 seconds!!");
            }
            else 
            {
                Console.WriteLine("Try again, you didn't press 'Enter' on time, your time difference was " 
                + answer + " seconds off");
            }
            Console.ReadLine();
        }
    }
}
