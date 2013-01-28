using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<DateTime, List<CustomerEvent>> CustomerEvents { get; set; }
        public double SatisfactionLevel { get; set; }
        public ModuleEnum[] Modules { get; set; }

        public Customer(string name, ModuleEnum[] modules)
        {
            Name = name;
            CustomerEvents = new Dictionary<DateTime, List<CustomerEvent>>();
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();

            Random r = new Random(rng.GetHashCode());

            SatisfactionLevel = r.NextDouble() * 10;
            Modules = modules;
        }

        public Customer Clone()
        {
            Customer tmp = new Customer(this.Name, this.Modules);
            return tmp;
        }

        public void AddEvent(Event addThis)
        {
            if (addThis is CustomerEvent)
            {
                if (!CustomerEvents.ContainsKey(addThis.Date))
                {
                    CustomerEvents[addThis.Date] = new List<CustomerEvent>();
                }
                CustomerEvents[addThis.Date].Add((CustomerEvent)addThis);//.clone();
            }
        }

        internal void Simulate(DateTime date, World world, List<Supplier> suppliers)
        {

        }

        private void ChangeValuesAccordingToEvent(CustomerEvent customerEvent)
        {
            if (customerEvent is CustomerFireEmployeesEvent)
            {

            }
        }

        private void ChangeValuesAccordingToEvent(SupplierEvent e)
        {
            if (this.Modules.Contains(e.Module))
            {
                if (e.Severity != SeverityEnum.NoEffect)
                {
                    switch (e.EventType)
                    {
                        case SupplierEventTypeEnum.Error:
                            this.DecreaseSatisfactionalLevel(e.Severity);
                            break;
                        case SupplierEventTypeEnum.Asset:
                            this.IncreaseSatisfactionalLevel(e.Severity);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void DecreaseSatisfactionalLevel(SeverityEnum severity)
        {
            double change = ValueAccordingToSeverity(severity);
            SatisfactionLevel -= change;
            if (SatisfactionLevel < 0)
                SatisfactionLevel = 0;
            Console.WriteLine("Changeing satisfactionlevel with {0} to {1} for {2}", change, this.SatisfactionLevel, this.Name);
        }

        private void IncreaseSatisfactionalLevel(SeverityEnum severity)
        {
            double change = ValueAccordingToSeverity(severity);
            SatisfactionLevel -= change;
            if (SatisfactionLevel > 10)
                SatisfactionLevel = 10;
            Console.WriteLine("Changeing satisfactionlevel with {0} to {1} for {2}", change, this.SatisfactionLevel, this.Name);
        }

        private double ValueAccordingToSeverity(SeverityEnum severity)
        {
            switch (severity)
            {
                case SeverityEnum.Catastrophic:
                    return 0.1;
                case SeverityEnum.Severe:
                    return 0.05;
                case SeverityEnum.Major:
                    return 0.03;
                case SeverityEnum.Minor:
                    return 0.01;
                case SeverityEnum.NoEffect:
                default:
                    return 0;
            }
        }
    }
}
