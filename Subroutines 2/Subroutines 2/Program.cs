using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subroutines_2
{
    class Program
    {
        static void Main(string[] args)
        {
            greeting("Alice");
            greeting("Tayyiba");
            Console.ReadLine();
        }
        public static void greeting(string name)
        {
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Pleased to meet you");
        }
    }
}
