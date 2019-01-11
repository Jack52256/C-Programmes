using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_init
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            String stars = "";
            for (int j = 0; j < number; j++)
            {
                stars = "";
                for (int i = 0; i < number; i++)
                {
                    stars = stars + "*";
                }
                Console.WriteLine(stars);
            }
            Console.ReadLine();
        }
    }
}
