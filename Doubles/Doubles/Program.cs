using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            double number = Convert.ToDouble(Console.ReadLine());
            double third = number / 3;
            Console.WriteLine("One third of " + number + " is " + third);
            Console.ReadLine();
        }
    }
}
