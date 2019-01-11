using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume_of_a_cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of your cylider (cm)");
            double height = Convert.ToDouble(Console.ReadLine());
            const double PI = 3.14159;
            Console.WriteLine("Enter the raius of your cylinder (cm)");
            double radius = Convert.ToDouble(Console.ReadLine());
            double volume = height * PI * radius * radius;
            Console.WriteLine("The volume of your cyliner is: " + volume + " cm squared");
            Console.ReadLine();
        }
    }
}
