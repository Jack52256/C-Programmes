using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_108_challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string joke;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("What did the shark say when he ate the clownfish?");
            joke = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This tastes a little funny");
            Console.ReadLine();
        }
    }
}
