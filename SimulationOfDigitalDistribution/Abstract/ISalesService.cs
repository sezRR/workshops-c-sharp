using SimulationOfDigitalDistribution.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationOfDigitalDistribution.Abstract
{
    public interface ISalesService
    {
        void BuyGame(Customer customer, Game game, Wallet wallet, Campaign campaign);
    }
}
