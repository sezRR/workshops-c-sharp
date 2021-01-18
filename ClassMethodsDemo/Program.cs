using System;

namespace ClassMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new();
            customer1.CustomerId = 1;
            customer1.CustomerFirstName = "Ahmet";
            customer1.CustomerLastName = "Balcı";
            customer1.CustomerBirthYear = 1992;

            Customer customer2 = new();
            customer2.CustomerId = 2;
            customer2.CustomerFirstName = "Halil";
            customer2.CustomerLastName = "Kara";
            customer2.CustomerBirthYear = 1978;

            CustomerManager customerManager = new();
            customerManager.Add(customer2);
            customerManager.Update(customer1);
            customerManager.Delete(customer2);
            customerManager.ListCustomers(customer1, customer2);

            Console.WriteLine("\n| END OF THE PROCESS |");
        }
    }

    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public int CustomerBirthYear { get; set; }
    }
}
