using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Supplier
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public Dictionary<DateTime, List<SupplierEvent>> SupplierEvents { get; set; }

        public Supplier(string name, int capacity)
        {
            this.Name = name;
            Capacity = capacity;

            SupplierEvents = new Dictionary<DateTime, List<SupplierEvent>>();

        }

        public void AddEvent(Event addThis)
        {
            if (addThis is SupplierEvent)
            {
                if (!SupplierEvents.ContainsKey(addThis.Date))
                {
                    SupplierEvents[addThis.Date] = new List<SupplierEvent>();
                }
                SupplierEvents[addThis.Date].Add((SupplierEvent)addThis);//.clone();
            }

        }

        internal void Simulate(DateTime date, World World)
        {

        }

        public Supplier Clone()
        {
            Supplier s = new Supplier(this.Name, this.Capacity);

            return s;
        }
    }
}
