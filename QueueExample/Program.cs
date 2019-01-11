using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace QueueExample
{
    class Program
    {
        public struct Cust
        {
            public string name;
            public DateTime entered;
        }

        static public Queue<Cust> till = new Queue<Cust>();

        static public Timer intervalTimer = new Timer();

        static public Timer serveTimer = new Timer();

        static public Random rnd = new Random();

        static public string[] names = { "john", "dave", "anne", "andrea", "mark", "matthew", "megan", "liz", "bob", "clare" };

        static public void AddToQueue()
        {
            Cust customer;

            Console.Write("New customer ");
            customer.name = names[rnd.Next(0, names.Length - 1)];
            Console.Write(customer.name);
            customer.entered = DateTime.Now;
            Console.WriteLine(" at " + customer.entered);

            till.Enqueue(customer);
        }

        static void DisplayQueueInfo()
        {
            Console.WriteLine("Queue size: " + till.Count());
            foreach (Cust c in till)
            {
                Console.WriteLine(c.name + " " + c.entered);
            }
        }

        static void OnIntervalEvent(object source, ElapsedEventArgs e)
        {
            intervalTimer.Enabled = false;
            AddToQueue();
            DisplayQueueInfo();
            
        }

        static void OnServeEvent(object source, ElapsedEventArgs e)
        {
            serveTimer.Enabled = false;
            till.Dequeue();
            Console.WriteLine("Customer Served, " + DateTime.Now);
            DisplayQueueInfo();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an arrival interval (ie 5000) in milliseconds");
            int ai = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a service interval (ie 7000) in milliseconds");
            int si = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Simulation running, wait for a service or arrival");

            while (true)
            {
                if (!intervalTimer.Enabled)
                {
                    intervalTimer = new Timer();
                    intervalTimer.Elapsed += new ElapsedEventHandler(OnIntervalEvent);
                    intervalTimer.Interval = ai;
                    intervalTimer.Enabled = true;
                }
                if (!serveTimer.Enabled)
                {
                    serveTimer = new Timer();
                    serveTimer.Elapsed += new ElapsedEventHandler(OnServeEvent);
                    serveTimer.Interval = si;
                    serveTimer.Enabled = true;
                }
            }
        }
    }
}
