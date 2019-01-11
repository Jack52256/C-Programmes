using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("What is your birthdate?");
            string birth = Console.ReadLine();
            DateTime startday = Convert.ToDateTime(birth);
            TimeSpan ts = (today - startday);

            Console.WriteLine("You have lived for " + ts.Days + " days / " + ts.TotalSeconds + " seconds.");
            Console.ReadLine();
        }
    }
}
