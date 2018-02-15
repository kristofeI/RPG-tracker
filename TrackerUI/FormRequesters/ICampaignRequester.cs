using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerUI.FormRequesters
{
    public interface ICampaignRequester
    {
        void CampaignEdited(CampaignModel model);
    }
}
