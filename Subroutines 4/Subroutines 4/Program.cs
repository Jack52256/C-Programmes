using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subroutines_4
{
    class Program
    {
        static void Main(string[] args)
        {
            line("O", 4);
            line("X", 7);
            line("L", 15);
            Console.ReadLine();
        }

        public static void line(string letter, int length)
        {
            string output = "";

            for (int i = 0; i < length; i++)
            {
                output = output + letter;
            }
            Console.WriteLine(output);
        }
    }
}
