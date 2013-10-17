using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Supplier : SimulatedObject
    {
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Supplier(string name, int capacity)
            : base()
        {
            this.Name = name;
            Capacity = capacity;
        }

        internal override void Simulate(Effect.Effect ef)
        {
            //if (ef is Effect.SupplierEffect)
            //{
            //    Console.WriteLine(String.Format("{0}, {1}", "Supplier effected", ef.ToString()));
            //}
        }

        public Supplier Clone()
        {
            Supplier s = new Supplier(this.Name, this.Capacity);
            return s;
        }
    }
}
