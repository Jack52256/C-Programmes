using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upper_and_lower_string_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string pro = "I love programming";
            string procap = pro.ToUpper();
            string prolow = pro.ToLower();
            Console.WriteLine(prolow);
            Console.WriteLine(procap);
            Console.ReadLine();
        }
    }
}
