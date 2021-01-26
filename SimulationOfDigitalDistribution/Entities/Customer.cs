using SimulationOfDigitalDistribution.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimulationOfDigitalDistribution.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
