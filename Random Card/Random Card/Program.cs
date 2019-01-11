using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            var capslock = Console.CapsLock;
            int card = r.Next(1, 12);
            int suit = r.Next(0, 3);
            string sn = "";
            string cn = "";
            while (capslock)   
            {
                switch (suit)
                {
                    case 0:
                        sn = "hearts";
                        break;
                    case 1:
                        sn = "spades";
                        break;
                    case 2:
                        sn = "clubs";
                        break;
                    case 3:
                        sn = "diamonds";
                        break;
                }

                switch (card)
                {
                    case 1:
                        cn = "Ace";
                        break;
                    case 10:
                        cn = "Jack";
                        break;
                    case 11:
                        cn = "Queen";
                        break;
                    case 12:
                        cn = "King";
                        break;
                    default:
                        cn = Convert.ToString(card + 1);
                        break;
                }
                string s = cn + " of " + sn;
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
