using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public abstract class SupplierEvent : Event
    {
        public SupplierEventTypeEnum EventType { get; set; }
        public ModuleEnum Module { get; set; }
        public SeverityEnum Severity { get; set; }


        public SupplierEvent(DateTime dateTime, SupplierEventTypeEnum type, ModuleEnum module, SeverityEnum severity)
            : base(dateTime)
        {
            EventType = type;
            Module = module;
            Severity = severity;
        }

    }
}
