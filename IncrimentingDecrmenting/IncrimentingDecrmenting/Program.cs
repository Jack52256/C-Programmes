using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrimentingDecrmenting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Increasing Variables
            int a = 1;
            a = a + 1;
            Console.WriteLine("A is " + a);

            Console.WriteLine("\n");
            //This can also be written as
            int b = 1;
            b++;
            Console.WriteLine("B is " + b);

            Console.WriteLine("\n");
            //Decreasing Variables
            int c = 1;
            c = c - 1;
            Console.WriteLine("C is " + c);
            //or
            int d = 1;
            d--;
            Console.WriteLine("D is " + d);

            Console.WriteLine("\n");
            string number;
            Console.WriteLine("Enter a number");
            number = Console.ReadLine();
            a = Convert.ToInt32(number);
            a++;
            Console.WriteLine("Plus one is " + a);

            Console.WriteLine("\n");
            string height;
            Console.WriteLine("Enter the height");
            height = Console.ReadLine();
            int h = Convert.ToInt32(height);
            string width;
            Console.WriteLine("Enter the width");
            width = Console.ReadLine();
            int w = Convert.ToInt32(width);
            string length;
            Console.WriteLine("Enter the length");
            length = Console.ReadLine();
            int l = Convert.ToInt32(length);
            int o;
            o = h * w * l;
            Console.WriteLine("The volume of the cuboid is " + o + " centimeters cubed");

            Console.WriteLine("\n");
            string number1;
            Console.WriteLine("Enter a number");
            number1 = Console.ReadLine();
            int no = Convert.ToInt32(number1);
            Console.WriteLine("1 times " + no + " is " + no);
            int moo = no * 2;
            Console.WriteLine("2 times " + no + " is " + moo);
            int ree = no * 3;
            Console.WriteLine("3 times " + no + " is " + ree);
            int yoo = no * 4;
            Console.WriteLine("4 times " + no + " is " + yoo);
            int aye = no * 5;
            Console.WriteLine("5 times " + no + " is " + aye);

            Console.WriteLine("\n");
            string how;
            Console.WriteLine("How many children are they?");
            how = Console.ReadLine();
            int v = Convert.ToInt32(how);
            string sweets;
            Console.WriteLine("How many sweets do they each have?");
            sweets = Console.ReadLine();
            int s = Convert.ToInt32(sweets);
            string ducks;
            Console.WriteLine("How many ducks were there?");
            ducks = Console.ReadLine();
            int u = Convert.ToInt32(ducks);
            string each;
            Console.WriteLine("How many sweets did each child give each duck?");
            each = Console.ReadLine();
            int e = Convert.ToInt32(each);
            int amount = ((v * s) - (e *(v * u))) - (v * 1);
            Console.WriteLine("There were " + v + " children each with a bag contraining " + s + " sweets." +
            "They walked past " + u + " ducks. Each child gave " + e + " sweets to each of the ducks and ate" +
            "one themself. They decided to put the rest into a pile. \n They counted the pile and found it contained " +
              + amount + " sweets");
            Console.ReadLine();
        }
    }
}
