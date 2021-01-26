using SimulationOfDigitalDistribution.Abstract;
using SimulationOfDigitalDistribution.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationOfDigitalDistribution.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine($"{campaign.NameOfCampaign} campaign added!");
            Console.WriteLine($"{campaign.DetailsOfCampaign}");
            Console.WriteLine($"{campaign.DateOfStartTheCampaign} - {campaign.DateOfEndTheCampaign}");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine($"{campaign.NameOfCampaign} campaign deleted!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine($"{campaign.NameOfCampaign} campaign updated!");
        }
    }
}
