using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_of_five_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            double second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your third number");
            double third = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your fourth number");
            double fourth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your fifth number");
            double fifth = Convert.ToDouble(Console.ReadLine());
            const int FIVE = 5;
            double average = first + second + third + fourth + fifth;
            double averagee = average / FIVE;
            Console.WriteLine("The average of your five numbers is " + averagee);
            Console.ReadLine();
        }
    }
}
