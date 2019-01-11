using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_boundaries
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter your mark for the test below:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 40)
            {
                Console.WriteLine("You failed the test");
            }
            else if (a >= 40 && a < 50)
            {
                Console.WriteLine("You scored a D");
            }
            else if (a >= 50 && a < 60)
            {
                Console.WriteLine("You scored a C");
            }
            else if (a >= 60 && a < 70)
            {
                Console.WriteLine("You scored a B");
            }
            else if (a >= 70)
            {
                Console.WriteLine("You scored an A");
            }
            Console.ReadLine();
        }
    }
}
