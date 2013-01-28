using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public abstract class CustomerEvent : Event
    {
        public CustomerEvent(DateTime datetime)
            : base(datetime)
        {

        }
    }
}
