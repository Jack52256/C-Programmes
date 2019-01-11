using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            do
            {
                Console.WriteLine("in Do...While");
                x++;
            }
            while (x > 3);

            while (y > 3) 
            {
                Console.WriteLine("im While");
                y++;
            }
            Console.ReadLine();
        }
    }
}
