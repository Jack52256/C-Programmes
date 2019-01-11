using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many marks did you get in the test?");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 60)
                Console.WriteLine("Well done you have passed");
            else
                Console.WriteLine("Sorry you have failed");
            Console.ReadLine();
        }
    }
}
