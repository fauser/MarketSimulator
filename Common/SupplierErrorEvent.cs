using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class SupplierErrorEvent : SupplierEvent
    {
        public SupplierErrorEvent(DateTime dateTime, ModuleEnum module, SeverityEnum severity)
            : base(dateTime, SupplierEventTypeEnum.Error, module, severity)
        {

        }
    }
}
