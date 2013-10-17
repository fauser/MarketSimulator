using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Customer : SimulatedObject
    {
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public double SatisfactionLevel { get; set; }
        public ModuleEnum[] Modules { get; set; }

        public Customer(string name, int customerId, ModuleEnum[] modules)
        {
            Name = name;
            CustomerId = customerId;
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();

            Random r = new Random(rng.GetHashCode());

            SatisfactionLevel = r.NextDouble() * 10;
            Modules = modules;
        }

        public Customer Clone()
        {
            Customer tmp = new Customer(this.Name, this.CustomerId, this.Modules);
            return tmp;
        }

        internal override void Simulate(Effect.Effect ef)
        {
            if (ef is Effect.CustomerEffect)
            {
                Console.WriteLine(String.Format("{0}, {1}", "           Customer affected", ef.ToString()));
                this.SatisfactionLevel += ((Effect.CustomerEffect)(ef)).SatisfactionChange;

                Console.WriteLine("             " + this.ToString());

            }
        }

        public override string ToString()
        {
            return String.Format("Name {0}, Satisfaction level {1}", this.Name, this.SatisfactionLevel);
        }

    }
}
