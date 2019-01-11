using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subroutines_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Square("X", 10);
            Console.ReadLine();
        }
        public static void line(string symbol, int size)
        {
            string output = "";

            for (int i = 0; i < size; i++)
            {
                output = output + symbol;
            }
            Console.WriteLine(output);
        }
        public static void Square(string symbol, int size)
        {

            for (int i = 0; i < size; i++)
            {
                line(symbol, size);
            } 
        }
    }
}
