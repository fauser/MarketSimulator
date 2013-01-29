using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Market;

namespace Common.Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation sim = new Simulation(DateTime.Parse("2013-01-01"), DateTime.Parse("2013-01-31"));
            //sim.World.AddEvent(new WorldEvent(DateTime.Parse("2013-01-01")));

            Supplier s = new Supplier("Agda", 1);
            //s.AddEvent(new CustomerFoundErrorEvent(DateTime.Parse("2013-01-03"), ModuleEnum.Expence, SeverityEnum.Major));
            //s.AddEvent(new CustomerFoundErrorEvent(DateTime.Parse("2013-01-03"), ModuleEnum.Expence, SeverityEnum.Major));
            //s.AddEvent(new CustomerFoundErrorEvent(DateTime.Parse("2013-01-05"), ModuleEnum.Payroll, SeverityEnum.Catastrophic));
            //s.AddEvent(new CustomerFoundErrorEvent(DateTime.Parse("2013-01-08"), ModuleEnum.Payroll, SeverityEnum.NoEffect));
            //s.AddEvent(new CustomerFoundErrorEvent(DateTime.Parse("2013-01-20"), ModuleEnum.Expence, SeverityEnum.Minor));
            sim.AddSupplier(s.Clone());

            Customer c = new Customer("Metso", new ModuleEnum[] { ModuleEnum.Payroll });
            sim.AddCustomer(c.Clone());

            c = new Customer("Bring Frigo", new ModuleEnum[] { ModuleEnum.Payroll, ModuleEnum.Expence });
            sim.AddCustomer(c.Clone());

            Console.WriteLine("Simulating");
            sim.PrintSuppliers();
            sim.PrintCustomers();
            sim.Simulate();


            Console.ReadKey();
        }
    }
}
