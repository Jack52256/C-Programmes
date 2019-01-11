    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailFence
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfRailFence = 7;
            int count1, count2 = 0;

            // add choice of encrypt or decrypt

            // allow user to enter their own plaintext
            string plainText = "hello world";

            // allow user to enter the size of the rail fence

            string cipherText = "";

            for (count1 = 0; count1 < sizeOfRailFence; count1++)
            {
                count2 = count1;
                while(count2<plainText.Length)
                {
                    cipherText += plainText[count2];
                    count2 += sizeOfRailFence;
                }
            }
            Console.WriteLine(cipherText);
            Console.WriteLine(plainText);
            Console.ReadLine();
        }
    }
}
