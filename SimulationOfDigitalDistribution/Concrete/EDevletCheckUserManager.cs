using SimulationOfDigitalDistribution.Abstract;
using SimulationOfDigitalDistribution.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationOfDigitalDistribution.Concrete
{
    class EDevletCheckUserManager : ICheckUserService
    {
        public void CheckUser(Customer customer)
        {
            Console.WriteLine($"{customer.FirstName} exists on the database.");
        }
    }
}
