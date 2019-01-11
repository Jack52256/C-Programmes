using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "";

            do
            {
                if(password !="")
                    Console.WriteLine("Please try again.");
                Console.WriteLine("Enter the password:");
                password = Console.ReadLine();
            }
            while (password != "11111");

            Console.WriteLine("Unlocked!");

            Console.ReadLine();
        }
    }
}
