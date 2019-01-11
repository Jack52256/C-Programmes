using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number please thanks c:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 1000; i++)
            {
                int times = i * number;
                Console.WriteLine(i + " multiplied by " + number + " is " + times);
            }
            Console.ReadLine();
        }
    }
}
