using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Program to demostrate adding numbers.
             * By J.Turner
             * */
            //Declare variables
            //Adding
            int a = 4;
            int b = 6;
            int c;
            c = a + b; //make c into A plus B
            //Show the values on the screen
            Console.WriteLine("A is " + a);
            Console.WriteLine("B is " + b);
            Console.WriteLine("A plus B is " + c);
            Console.WriteLine("\n");
            int d = 20;
            int e = 25;
            int f;
            f = d + e;
            Console.WriteLine("D is " + d);
            Console.WriteLine("E is " + e);
            Console.WriteLine("D + E is " + f);
            Console.WriteLine("\n");
            //Subtracting
            int g = 10;
            int h = 7;
            int i;
            i = g - h;
            Console.WriteLine("G is " + g);
            Console.WriteLine("H is " + h);
            Console.WriteLine("G - H is " + i);
            Console.WriteLine("\n");
            //Multiplying
            int j = 6;
            int k = 8;
            int l;
            l = j * k;
            Console.WriteLine("J is " + j);
            Console.WriteLine("K is " + k);
            Console.WriteLine("J * K is " + l);
            Console.WriteLine("\n");
            //Dividing
            int m = 81;
            int n = 9;
            int o;
            o = 81 / 9;
            Console.WriteLine("M is " + m);
            Console.WriteLine("N is " + n);
            Console.WriteLine("M / N is " + o);
            Console.ReadLine(); //stops the program from finishing 

        }
    }
}
