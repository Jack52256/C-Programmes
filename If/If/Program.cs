using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (A)");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a second number (B)");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            Console.WriteLine("A is bigger than B");
            else if (a == b)
            Console.WriteLine("A is the same as B");
            else
            Console.WriteLine("A is smaller than B");
            Console.ReadLine();
        }
    }
}
