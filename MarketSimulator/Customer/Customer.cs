using MarketSimulator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSimulator.Customer
{
    class Customer
    {
        public Customer()
        {
            List<Module> m = new List<Module>();

            m.Add(Module.Drift);
        }
        

    }
}
