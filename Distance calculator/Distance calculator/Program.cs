using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string speed;
            Console.WriteLine("What is the speed?");
            speed = Console.ReadLine();
            string time;
            Console.WriteLine("What is the time taken in seconds?");
            time = Console.ReadLine();
            int a = Convert.ToInt32(speed);
            int b = Convert.ToInt32(time);
            int c = a * b;
            Console.WriteLine("The distance was " + c + " meters");
            Console.ReadLine();
        }
    }
}
