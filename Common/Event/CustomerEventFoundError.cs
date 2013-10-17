using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Event
{
    public class CustomerEventFoundError : CustomerEvent
    {
        public SupplierEventTypeEnum EventType { get; set; }
        public ModuleEnum Module { get; set; }
        public SeverityEnum Severity { get; set; }
        public int CustomerID { get; set; }


        public CustomerEventFoundError(DateTime dateTime, int customerId, SupplierEventTypeEnum type, ModuleEnum module, SeverityEnum severity)
            : base(dateTime)
        {
            EventType = type;
            Module = module;
            Severity = severity;
            CustomerID = customerId;
        }
    }
}
