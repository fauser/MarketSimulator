using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Event
{
    public class WorldEvent : Event
    {
        public WorldEvent(DateTime date)
            : base(date)
        {

        }
    }
}
