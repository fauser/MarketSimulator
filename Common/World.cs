using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class World : SimulatedObject
    {

        public World()
            : base()
        {
        }

        internal override void Simulate(Effect.Effect ef)
        {
            if (ef is Effect.WorldEffect)
            {
                Console.WriteLine(String.Format("{0}, {1}", "           World affected", ef.ToString()));
            }
        }
    }
}
