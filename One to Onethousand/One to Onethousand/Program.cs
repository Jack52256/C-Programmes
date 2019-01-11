using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_to_Onethousand
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 1001; a++)
            {
                if ((a % 2) == 0)
                {
                    Console.Write(a + " is even");
                }
                else
                {
                    Console.Write(a + " is odd");
                }
                if (a < 250)
                {
                    Console.WriteLine(" and smaller than 250");
                }
                else if (a == 250)
                {
                    Console.WriteLine(" and is equal to 250");
                }
                if (a > 250)
                {
                        if (a < 500)
                        {
                            Console.WriteLine(" and smaller than 500");
                        }
                        else if (a == 500)
                        {
                            Console.WriteLine(" and equal to 500");
                        }
                        if (a > 500)
                        {
                               if (a < 750)
                               {
                                   Console.WriteLine(" and smaller than 750");
                               }
                               else if (a == 750)
                               {
                                   Console.WriteLine(" and equal to 750");
                               }
                        if (a > 750)
                        {
                            if (a < 1000)
                            {
                                Console.WriteLine(" and smaller than 1000");
                            }
                            else if (a == 1000)
                            {
                                Console.WriteLine(" and equal to 1000");
                            }
                            else
                            {
                                Console.WriteLine("");
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
