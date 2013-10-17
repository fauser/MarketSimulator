using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Event
{
    public abstract class Event
    {
        public DateTime Date { get; set; }
        public List<Effect.Effect> Effects { get; set; }

        public Event(DateTime dateTime)
        {
            this.Date = dateTime.Date;
            this.Effects = new List<Effect.Effect>();
        }
    }
}
