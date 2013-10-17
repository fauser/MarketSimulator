using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Event
{
    public class CustomerEventFireEmployees : CustomerEvent
    {
        public int PeoplesToFire { get; set; }

        public CustomerEventFireEmployees(DateTime datetime, int peoplesToFire)
            : base(datetime)
        {
            PeoplesToFire = peoplesToFire;
        }
    }
}
