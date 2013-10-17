using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public abstract class SimulatedObject
    {
        public SimulatedObject()
        {

        }

        virtual internal void Simulate(Effect.Effect ef)
        {
            //throw new NotImplementedException();
        }
    }
}
