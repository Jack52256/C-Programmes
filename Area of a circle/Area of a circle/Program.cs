using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_a_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius (cm)");
            const double PI = 3.14159;
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = PI * radius * radius;
            Console.WriteLine("The area of the circle is: " + area + " cm squared");
            Console.ReadLine();
        }
    }
}
