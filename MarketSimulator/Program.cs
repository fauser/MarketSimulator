using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Market.Market m = new Market.Market();
            m.init();

            while (true)
            {
                ConsoleKey lastKey = Console.ReadKey().Key;

                if (lastKey == ConsoleKey.Escape)
                    break;
            }
        }
    }
}
