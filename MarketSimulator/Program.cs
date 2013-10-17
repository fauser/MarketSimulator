using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Event;
using Common.Market;

namespace Common.Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation sim = new Simulation(DateTime.Parse("2013-01-01"), DateTime.Parse("2013-01-31"));
            Supplier s = new Supplier("Visma Agda", 1);

            sim.AddSupplier(s);

            Customer c = new Customer("Metso", 3242, new ModuleEnum[] { ModuleEnum.Payroll });
            sim.AddCustomer(c);

            c = new Customer("Tamro", 48, new ModuleEnum[] { ModuleEnum.Payroll, ModuleEnum.Expence });
            sim.AddCustomer(c);

            sim.AddEvent(new WorldEventZombieApocalysm(DateTime.Parse("2013-01-01")));

            sim.AddEvent(new SupplierEventManifestingDefence(DateTime.Parse("2013-01-10")));

            Console.WriteLine("Simulating");

            sim.PrintWorld();
            sim.PrintSuppliers();
            sim.PrintCustomers();
            
            sim.Simulate();


            Console.ReadKey();
        }
    }
}
