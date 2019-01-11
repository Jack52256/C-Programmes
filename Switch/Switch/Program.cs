using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press the 'Enter' key when you are ready to type the alphabet");
            Console.ReadKey();
            DateTime today = DateTime.Now;
            string a = Console.ReadLine();
            DateTime n = DateTime.Now;
            TimeSpan b = (n - today);
            switch (a)
            {
                case "ABCDEFGHIJKLMNOPQRSTUVWXYZ":
                case "abcdefghijklmnopqrstuvwxyz":
                    Console.WriteLine("You managed to type the alphabet correctly in " + b + " seconds");
                    break;
                default:
                    Console.WriteLine("You typed the alphabet wrong, that is a Y2 skill. Shame on you, try again!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
