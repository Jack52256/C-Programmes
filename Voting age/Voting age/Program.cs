using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_age
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Type your birthdate to find out if you are legal to vote:");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            TimeSpan age = (dob - today);
            int eee = (int)age.TotalDays / 365;
            if (eee >= 18) 
            {
                Console.WriteLine("You are old enough to vote!");
            }
            else
            {
                Console.WriteLine("You aren't old enough to vote, why are you even here? I'm sure you knew that already.");
            }
            Console.ReadLine();
        }
    }
}
