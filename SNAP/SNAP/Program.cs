using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAP
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Enter your 1st number:");
            x = Convert.ToDouble(Console.ReadLine());
            double y;
            Console.WriteLine("Enter your 2nd number:");
            y = Convert.ToDouble(Console.ReadLine());
            double z;
            Console.WriteLine("Enter your 3rd number:");
            z = Convert.ToDouble(Console.ReadLine());
            if (x == y)
            {
            Console.WriteLine("SNAP");
            }
            else if (x == z)
            {
            Console.WriteLine("SNAP");
            }
            else 
            {
            Console.WriteLine("No snap ;(");
            }
            Console.ReadLine();
        }
    }
}
