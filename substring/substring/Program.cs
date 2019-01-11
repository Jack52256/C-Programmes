using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            Console.WriteLine("Please enter a sentence:");
            t = Console.ReadLine();;
            string e = t.Substring(2, 5);
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}
