using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subroutines
{
    class Program
    {
        static void Main(string[] args)
        {
            greeting();
            greeting();
            goodbye();
            goodbye();
            goodbye();
            Console.ReadLine();
        }

        public static void greeting()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Pleased to meet you");
        }

        public static void goodbye()
        {
            Console.WriteLine("Goodbye");
            Console.WriteLine("See you soon!");
        }
    }
}
