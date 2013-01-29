using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class World
    {
        public Dictionary<DateTime, List<WorldEvent>> WorldEvents { get; set; }

        public World()
        {
            WorldEvents = new Dictionary<DateTime, List<WorldEvent>>();
        }

        public void AddEvent(WorldEvent addThis)
        {

            if (!WorldEvents.ContainsKey(addThis.Date))
            {
                WorldEvents[addThis.Date] = new List<WorldEvent>();
            }
            WorldEvents[addThis.Date].Add((WorldEvent)addThis);//.clone();

        }


        internal static void Update(DateTime d)
        {
            //
        }
    }
}
