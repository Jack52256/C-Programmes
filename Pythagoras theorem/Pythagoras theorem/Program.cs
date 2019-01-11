using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagoras_theorem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This programme is to find the hypotenuse of a right-angled triangle to 2 decimal" +
            " places");
            Console.WriteLine("Enter the value of one of the sides (cm)");
            double sidea = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of the other side (cm)");
            double sideb = Convert.ToDouble(Console.ReadLine());
            double sqrtme = sidea * sidea * sideb * sideb;
            double sqrtd = Math.Sqrt(sqrtme);
            double answer = Math.Round(sqrtd, 2);
            Console.WriteLine("The hypotenuse of the right-angled triangle is: " + answer + " cm");
            Console.ReadLine();
        }
    }
}
