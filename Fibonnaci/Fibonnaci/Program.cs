using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            for (int i = 1; i < 21; i ++)
            {
                int c = a + b;
                a = b;
                b = c;
                Console.WriteLine(b);
            }
            Console.ReadLine();
        }
    }
}
