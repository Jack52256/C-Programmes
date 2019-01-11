using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string one;
            Console.WriteLine("Person One enter your name:");
            one = Console.ReadLine();
            int onel = one.Length;
            string two;
            Console.WriteLine("Person Two enter your name:");
            two = Console.ReadLine();
            int twol = two.Length;
            if (onel > twol)
            {
                Console.WriteLine(one + " has the longest name.");
            }
            else if (twol > onel)
            {
                Console.WriteLine(two + " has the longest name.");
            }
            else
            {
                Console.WriteLine(one + " and " + two + " have the same length name.");
            }
            Console.ReadLine();
        }
    }
}
