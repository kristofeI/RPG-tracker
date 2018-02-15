using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;
using TrackerUI.FormRequesters;

namespace TrackerUI
{
    public partial class RPGSystem : Form, ICampaignRequester
    {
        List<string> rpgSystems = new List<string>() { "Neuroshima / Savage Worlds" };
        List<CampaignModel> campaigns = new List<CampaignModel>();
        RPGSystemModel currentRPGSystem;

        public RPGSystem()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            systemDropDown.DataSource = rpgSystems;
            
            if (currentRPGSystem != null)
            {
                campaigns = currentRPGSystem.Campaigns;
            }

            campaignDropDown.DataSource = null;
            campaignDropDown.DataSource = campaigns;
            campaignDropDown.DisplayMember = "CampaignName";
        }

        private void campaignAddButton_Click(object sender, EventArgs e)
        {
            CampaignModel newCampaign = new CampaignModel(newCampaignTextBox.Text);

            GlobalConfig.Connection.AddNewCampaign(newCampaign);

            currentRPGSystem.Campaigns.Add(newCampaign);

            GlobalConfig.Connection.UpdateRPGSystem(currentRPGSystem);

            WireUpLists();
        }

        private void campaignRemoveButton_Click(object sender, EventArgs e)
        {
            CampaignModel selectedCampaign = (CampaignModel)campaignDropDown.SelectedItem;

            currentRPGSystem.Campaigns.Remove(selectedCampaign);

            GlobalConfig.Connection.UpdateRPGSystem(currentRPGSystem);

            WireUpLists();
        }

        private void systemDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            RPGSystemModel rpgSystem = new RPGSystemModel(systemDropDown.Text);

            if (GlobalConfig.Connection.GetRPGSystem(rpgSystem) != null)
            {
                currentRPGSystem = GlobalConfig.Connection.GetRPGSystem(rpgSystem);
            }
            else
            {
                GlobalConfig.Connection.AddNewRPGSystem(rpgSystem);

                currentRPGSystem = GlobalConfig.Connection.GetRPGSystem(rpgSystem);
            }

            WireUpLists();
        }

        private void loadCampaignButton_Click(object sender, EventArgs e)
        {
            CampaignModel selectedCampaign = (CampaignModel)campaignDropDown.SelectedItem;

            GMTrackerUI frm = new GMTrackerUI(this, selectedCampaign);
            frm.Show();
        }

        public void CampaignEdited(CampaignModel model)
        {
            GlobalConfig.Connection.UpdateCampaign(model);
        }
    }
}
