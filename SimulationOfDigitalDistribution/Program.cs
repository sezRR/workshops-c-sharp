using SimulationOfDigitalDistribution.Abstract;
using SimulationOfDigitalDistribution.Concrete;
using SimulationOfDigitalDistribution.Entities;
using System;

namespace SimulationOfDigitalDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Sezer",
                LastName = "Tetik",
                NationalityId = "01234567891",
                DateOfBirth = new DateTime(2000, 1, 19),
            };

            Wallet wallet1 = new Wallet
            {
                Id = 1,
                WalletId = "AAAA0001",
                Balance = 30,
                CurrencyUnit = "$"
            };

            Game game1 = new Game
            {
                Id = 1,
                Name = "Counter-Strike: Global Offensive",
                UnitPrice = 25,
                QuantityPerUnit = "1 piece CS:GO",
                DateOfPublish = new DateTime(2012, 8, 21)
            };

            Campaign campaign1 = new Campaign
            {
                Id = 1,
                NameOfCampaign = "A New Year",
                DetailsOfCampaign = "A New Year Campaign On The Occasion Of The New Year!",
                DiscountAmount = 10,
                DateOfStartTheCampaign = new DateTime(2020, 12, 25),
                DateOfEndTheCampaign = new DateTime(2021, 1, 12)
            };

            ICustomerService customerManager = new CustomerManager();
            customerManager.Add(customer1);

            Console.WriteLine("\n-------------------------------------------------------\n");

            ICheckUserService eDevletCheckUserManager = new EDevletCheckUserManager();
            eDevletCheckUserManager.CheckUser(customer1);

            Console.WriteLine("\n-------------------------------------------------------\n");

            ICampaignService campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            Console.WriteLine("");
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign1);

            Console.WriteLine("\n-------------------------------------------------------\n");

            ISalesService salesManager = new SalesManager();
            salesManager.BuyGame(customer1, game1, wallet1, campaign1);
        }
    }
}
