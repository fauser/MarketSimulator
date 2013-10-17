using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Event;

namespace Common
{
    public class Simulation
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Dictionary<int, Customer> Customers { get; set; }
        public World World { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<Event.Event> Events { get; set; }

        public Simulation(DateTime start, DateTime end)
        {
            Start = start.Date;
            End = end.Date;
            World = new World();
            Suppliers = new List<Supplier>();
            Customers = new Dictionary<int, Customer>();
            Events = new List<Event.Event>();
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
                Console.WriteLine(" Simulating " + d.ToShortDateString());

                var events = from ev in this.Events
                             where ev.Date.Date.Equals(d.Date.Date)
                             orderby ev.Date
                             select ev;

                foreach (Event.Event ev in events)
                {
                    Console.WriteLine("     Event occured, " + ev.ToString());
                    foreach (Effect.Effect ef in ev.Effects)
                    {

                        World.Simulate(ef);

                        foreach (Supplier s in Suppliers)
                        {
                            s.Simulate(ef);
                        }

                        foreach (KeyValuePair<int, Customer> valuepair in Customers)
                        {
                            valuepair.Value.Simulate(ef);
                        }


                    }
                }
            }
        }

        public void PrintWorld()
        {
            Console.WriteLine(" World");

            Console.WriteLine("     {0}", this.World.ToString());
        }

        public void PrintSuppliers()
        {
            Console.WriteLine(" Suppliers of simulation");
            foreach (Supplier s in Suppliers)
            {
                Console.WriteLine("     Name {0}, Initial capacity {1}", s.Name, s.Capacity);
            }
        }

        public void PrintCustomers()
        {
            Console.WriteLine(" Customers of simulation");
            foreach (KeyValuePair<int, Customer> c in Customers)
            {
                Console.WriteLine("     " + c.Value.ToString());
            }
        }

        public void AddEvent(Event.Event addThis)
        {
            Events.Add(addThis);
        }

    }
}
