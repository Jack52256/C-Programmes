using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012_old_spec_Flowchart
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            int column = 8;
                while(column >= 1)
                {
                    Console.WriteLine("Enter bit value");
                    int bit = Convert.ToInt32(Console.ReadLine());
                    answer = answer + (column * bit);
                    column = column / 2;
                }
            Console.WriteLine("Decimal value is:" + answer);
            Console.ReadLine();
        }
    }
}
