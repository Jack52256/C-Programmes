using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowel_count
{
    class Program
    {
        static void Main(string[] args)
        {
            int counta = 0;
            int counte = 0;
            int counti = 0;
            int counto = 0;
            int countu = 0;
            Console.WriteLine("Please enter your sentence:");
            string text = Console.ReadLine();
            text = text.ToLower();

            for (int i = 0; i < (text.Length); i++)
            {
                string letter = text.Substring(i, 1);
                if (letter == "a")
                {
                    counta++;
                }
                else if (letter == "e")
                {
                    counte++;
                }
                else if (letter == "i")
                {
                    counti++;
                }
                else if (letter == "o")
                {
                    counto++;
                }
                else if (letter == "u")
                {
                    countu++;
                }
            }
            Console.WriteLine("The letter a occurs " + counta + " times");
            Console.WriteLine("The letter e occurs " + counte + " times");
            Console.WriteLine("The letter i occurs " + counti + " times");
            Console.WriteLine("The letter o occurs " + counto + " times");
            Console.WriteLine("The letter u occurs " + countu + " times");
            Console.ReadLine();
        }
    }
}
