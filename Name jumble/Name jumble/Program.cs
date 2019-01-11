using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_jumble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name:");
            string f = Console.ReadLine();
            Console.WriteLine("Please enter your second name:");
            string l = Console.ReadLine();
            Console.WriteLine("Output:");
            string fa = f.Substring(2, 2);
            string fb = fa.ToUpper();
            string la = l.Substring(2, 2);
            String lb = la.ToLower();
            Console.WriteLine(fb + lb);
            Console.ReadLine();
        }
    }
}
