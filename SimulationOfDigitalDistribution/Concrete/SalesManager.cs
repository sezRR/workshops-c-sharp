using SimulationOfDigitalDistribution.Abstract;
using SimulationOfDigitalDistribution.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationOfDigitalDistribution.Concrete
{
    class SalesManager : ISalesService
    {
        public void BuyGame(Customer customer, Game game, Wallet wallet, Campaign campaign)
        {
            if (wallet.Balance >= game.UnitPrice)
            {
                if (campaign == null)
                {
                    Console.WriteLine($"{customer.FirstName} purchased '{game.Name}' by {game.UnitPrice}{wallet.CurrencyUnit}!");
                    Console.WriteLine($"Old Balance: {wallet.Balance}{wallet.CurrencyUnit}");
                    wallet.Balance -= game.UnitPrice;
                    Console.WriteLine($"New Balance: {wallet.Balance}{wallet.CurrencyUnit}");
                }
                else
                {
                    Console.WriteLine($"{customer.FirstName} purchased '{game.Name}' by {game.UnitPrice}{wallet.CurrencyUnit} on {campaign.NameOfCampaign} campaign!");
                    Console.WriteLine($"Game Price: {game.UnitPrice}{wallet.CurrencyUnit}\n");
                    Console.WriteLine($"Old Balance: {wallet.Balance}{wallet.CurrencyUnit}");
                    wallet.Balance -= game.UnitPrice - campaign.DiscountAmount;
                    Console.WriteLine($"New Balance: {wallet.Balance}{wallet.CurrencyUnit}");
                    Console.WriteLine($"Discount Amount: +{campaign.DiscountAmount}{wallet.CurrencyUnit}");
                }
            }
            else
            {
                Console.WriteLine($"{customer.FirstName}, you do not have enough money on your wallet({wallet.Balance}{wallet.CurrencyUnit}) to buy '{game.Name}'({game.UnitPrice}{wallet.CurrencyUnit})!");
            }
        }
    }
}
