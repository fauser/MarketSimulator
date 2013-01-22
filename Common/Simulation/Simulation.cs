using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Market;

namespace Common.Simulation
{
    public class Simulation
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Simulation(DateTime start, DateTime end)
        {
            Start = start;
            End = end;

            Market.Market m = new Market.Market();

        }



    }
}
