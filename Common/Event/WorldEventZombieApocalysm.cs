using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Event
{
    public class WorldEventZombieApocalysm : WorldEvent
    {
        public WorldEventZombieApocalysm(DateTime date)
            : base(date)
        {
            Effects.Add(new Effect.WorldEffectFightForYourLife());
            Effects.Add(new Effect.CustomerEffectNotVeryFond() { SatisfactionChange = -0.5 });
        }

        public override string ToString()
        {
            return "Zombie Apocalysm!!!";
        }
    }
}
