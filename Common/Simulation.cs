using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Simulation
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Dictionary<int, Customer> Customers { get; set; }
        public World World { get; set; }

        public List<Supplier> Suppliers { get; set; }

        public Simulation(DateTime start, DateTime end)
        {
            Start = start.Date;
            End = end.Date;
            World = new World();
            Suppliers = new List<Supplier>();
            Customers = new Dictionary<int, Customer>();
        }

        public void AddSupplier(Supplier addThis)
        {
            Suppliers.Add(addThis);
        }

        public void AddCustomer(Customer addThis)
        {
            Customers.Add(Customers.Count, addThis.Clone());
        }

        public void Simulate()
        {
            for (DateTime d = this.Start; d <= this.End; d = d.AddDays(1))
            {
                Console.WriteLine("Simulating " + d.ToShortDateString());

                Console.WriteLine("Simulating world");
                World.Simulate(d);

                Console.WriteLine("Simulating supplier events");
                foreach (Supplier s in Suppliers)
                {
                    s.Simulate(d, World);
                }

                Console.WriteLine("Simulating customer events");
                foreach (KeyValuePair<int, Customer> valuepair in Customers)
                {
                    valuepair.Value.Simulate(d, World, Suppliers);
                }
            }
        }

        public void PrintSuppliers()
        {
            Console.WriteLine("Suppliers of simulation");
            foreach (Supplier s in Suppliers)
            {
                Console.WriteLine("Name {0}, Initial capacity {1}", s.Name, s.Capacity);
            }
        }

        public void PrintCustomers()
        {
            Console.WriteLine("Customers of simulation");
            foreach (KeyValuePair<int, Customer> c in Customers)
            {
                Console.WriteLine("Name {0}, Initial level {1}", c.Value.Name, c.Value.SatisfactionLevel);
            }
        }
    }
}
