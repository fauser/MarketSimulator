using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Market;

namespace Common.Market
{
    class Program
    {
        static void Main(string[] args)
        {
            //Market m = new Market();
            //m.init();

            bool simulationStarted = false;

            while (true)
            {
                ConsoleKey lastKey = Console.ReadKey().Key;


                switch (lastKey)
                {
                    case ConsoleKey.A:
                        if (!simulationStarted)
                        {
                            Console.Clear();
                            //Console.WriteLine(m.ListCustomers());
                        }
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.WriteLine("Terminating");
                        simulationStarted = false;
                        Console.ReadKey();
                        return;
                    case ConsoleKey.S:
                        if (!simulationStarted)
                        {
                            Console.Clear();
                            Console.WriteLine("Starting simulation");
                            simulationStarted = true;
                        }
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
