using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Event
{
    public class SupplierEventManifestingDefence : SupplierEvent
    {
        public SupplierEventManifestingDefence(DateTime date)
            : base(date)
        {
            Effects.Add(new Effect.CustomerEffectNewHero() { SatisfactionChange = 3 });
        }

        public override string ToString()
        {
            return "We will save you.";
        }

    }
}
