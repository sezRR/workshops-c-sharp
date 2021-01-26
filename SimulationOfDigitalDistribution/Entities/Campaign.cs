using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationOfDigitalDistribution.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string NameOfCampaign { get; set; }
        public string DetailsOfCampaign { get; set; }
        public decimal DiscountAmount { get; set; }
        public DateTime DateOfStartTheCampaign { get; set; }
        public DateTime DateOfEndTheCampaign { get; set; }
    }
}
