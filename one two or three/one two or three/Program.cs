using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_two_or_three
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            do
            {
                if (x != 1 || x != 2 || x != 3)
                {
                    Console.WriteLine("The number you entered was not between 1 abd 3");
                }
                Console.WriteLine("Please enter a number from 1-3");
                x = Convert.ToInt32(Console.ReadLine());
            }
            while (x == 1 || x == 2 ||x == 3);
            if (x == 1)
            {
                Console.WriteLine("You selected number ONE");

            }
            
            Console.ReadLine();
        }
    }
}
