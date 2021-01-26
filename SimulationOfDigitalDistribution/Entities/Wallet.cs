using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationOfDigitalDistribution.Entities
{
    public class Wallet
    {
        public int Id { get; set; }
        public string WalletId { get; set; }
        public decimal Balance { get; set; }
        public string CurrencyUnit { get; set; }
    }
}
