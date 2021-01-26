using SimulationOfDigitalDistribution.Abstract;
using SimulationOfDigitalDistribution.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationOfDigitalDistribution.Concrete
{
    class CustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.FirstName} {customer.LastName} added to database.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine($"{customer.FirstName} {customer.LastName} updated on database.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine($"{customer.FirstName} {customer.LastName} deleted on database.");
        }
    }
}
