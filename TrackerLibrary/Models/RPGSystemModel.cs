using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class RPGSystemModel
    {
        public int Id { get; set; }

        public string SystemName { get; set; }

        public List<CampaignModel> Campaigns { get; set; } = new List<CampaignModel>();

        public RPGSystemModel()
        {

        }

        public RPGSystemModel(string systemName)
        {
            SystemName = systemName;
        }
    }
}
