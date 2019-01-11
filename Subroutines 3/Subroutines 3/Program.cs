using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subroutines_3
{
    class Program
    {
        static void Main(string[] args)
        {
            greeting("Jack", true);
            greeting("Bill", false);
            Console.ReadLine();
        }

        public static void greeting(string firstname,bool liked)
        {
            Console.WriteLine("Hello " + firstname);
            if (liked == true)
            {
                Console.WriteLine("Nice to meet you");
            }
            else
            {
                Console.WriteLine("I don't like you - go away");
            }
        }
    }
}
