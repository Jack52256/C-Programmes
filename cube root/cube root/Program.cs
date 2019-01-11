using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cube_root
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Enter the number you wish to cube root");
            n = Convert.ToInt32(Console.ReadLine());
            for (int a = 0; a < n; a++)
            {
                int b = a * a * a;
                if (b == n)
                {
                    Console.WriteLine("The cube root of " + n + " is " + a);
                }
            }
            Console.ReadLine();
        }
    }
}
