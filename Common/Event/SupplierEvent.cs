using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Event
{
    public abstract class SupplierEvent : Event
    {
        public SupplierEvent(DateTime dateTime)
            : base(dateTime)
        {

        }
    }
}
