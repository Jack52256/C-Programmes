using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubles_and_constants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of centimetres:");
            int cm = Convert.ToInt32(Console.ReadLine());
            double feet;
            feet = cm / 30.48;
            double inch;
            inch = cm / 2.54;
            double meter;
            meter = cm / 100.00;
            Console.WriteLine(cm + " centimetres is the same as " + feet + " feet, " + inch + "" +
            " inches and " + meter + " meters.");
            Console.ReadLine();
        }
    }
}
