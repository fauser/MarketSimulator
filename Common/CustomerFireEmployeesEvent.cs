using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CustomerFireEmployeesEvent : CustomerEvent
    {
        public int PeoplesToFire { get; set; }

        public CustomerFireEmployeesEvent(DateTime datetime, int peoplesToFire)
            : base(datetime)
        {
            PeoplesToFire = peoplesToFire;
        }
    }
}
