using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount you wish to convert (£s)");
            double pounds = Convert.ToDouble(Console.ReadLine());
            const double USDCONVERSION = 2.04601;
            const double EUROCONVERSION = 1.44694;
            const double YENCONVERSION = 240.283;
            const double RUPEECONVERSION = 80.4568;
            double usd = pounds * USDCONVERSION;
            double euro = pounds * EUROCONVERSION;
            double yen = pounds * YENCONVERSION;
            double rupee = pounds * RUPEECONVERSION;
            Console.WriteLine("Your £" + pounds + " converts to:");
            Console.WriteLine(usd + " United States Dollars");
            Console.WriteLine(euro + " Euros");
            Console.WriteLine(yen + " Yen");
            Console.WriteLine(rupee + " Rupees");
            Console.ReadLine();
        }
    }
}
