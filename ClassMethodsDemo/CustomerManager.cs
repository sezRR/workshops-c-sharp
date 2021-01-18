using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodsDemo
{
     class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"-------------------ADD CUSTOMER-------------------");

            Console.WriteLine($"{customer.CustomerId}:");
            Console.WriteLine($"First Name: {customer.CustomerFirstName}");
            Console.WriteLine($"Last Name: {customer.CustomerLastName}");
            Console.WriteLine($"Birth Year: {customer.CustomerBirthYear}");
            Console.WriteLine($"Customer has been added to database.\n");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine($"-------------------UPDATE CUSTOMER-------------------");

            Console.WriteLine($"{customer.CustomerId}:");
            Console.WriteLine($"First Name: {customer.CustomerFirstName}");
            Console.WriteLine($"Last Name: {customer.CustomerLastName}");
            Console.WriteLine($"Birth Year: {customer.CustomerBirthYear}");
            Console.WriteLine($"Customer has been updated on database.\n");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine($"-------------------DELETE CUSTOMER-------------------");

            Console.WriteLine($"{customer.CustomerId}:");
            Console.WriteLine($"First Name: {customer.CustomerFirstName}");
            Console.WriteLine($"Last Name: {customer.CustomerLastName}");
            Console.WriteLine($"Birth Year: {customer.CustomerBirthYear}");
            Console.WriteLine($"Customer has been deleted on database.\n");
        }

        public void ListCustomers(params Customer[] customers)
        {
            Console.WriteLine($"-------------------CUSTOMERS LIST-------------------");

            if (customers.Length > 0)
            {
                foreach (var customer in customers)
                {
                    Console.WriteLine($"{customer.CustomerId}:");
                    Console.WriteLine($"First Name: {customer.CustomerFirstName}");
                    Console.WriteLine($"Last Name: {customer.CustomerLastName}");
                    Console.WriteLine($"Birth Year: {customer.CustomerBirthYear}\n");
                }
            }
            else
            {
                Console.WriteLine("Customers database is empty!");
            }
        }
    }
}
