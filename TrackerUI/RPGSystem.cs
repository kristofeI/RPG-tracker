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
        List<RPGSystemModel> rpgSystems = new List<RPGSystemModel>() { new RPGSystemModel { Id = 1, SystemName = "Neuroshima / Savage Worlds" } };
        RPGSystemModel currentRPGSystem;

        public RPGSystem()
        {
            InitializeComponent();

            CheckWhichRpgSystemsAreValid();

            WireUpLists();
        }

        private void WireUpLists()
        {
            systemDropDown.DataSource = null;
            systemDropDown.DataSource = rpgSystems;
            systemDropDown.DisplayMember = "DisplayedRpgSystem";

            currentRPGSystem = (RPGSystemModel)systemDropDown.SelectedItem;

            if (currentRPGSystem != null)
            {
                campaignDropDown.DataSource = null;
                campaignDropDown.DataSource = currentRPGSystem.Campaigns;
                campaignDropDown.DisplayMember = "CampaignName";
            }
        }

        private void CheckWhichRpgSystemsAreValid()
        {
            rpgSystems = GlobalConfig.Connection.MakeProperListOfRpgSystems(rpgSystems);
        }

        private void campaignAddButton_Click(object sender, EventArgs e)
        {
            CampaignModel newCampaign = new CampaignModel(newCampaignTextBox.Text);

            currentRPGSystem.Campaigns.Add(GlobalConfig.Connection.AddNewCampaign(newCampaign));

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
            //RPGSystemModel rpgSystem = (RPGSystemModel)systemDropDown.SelectedItem;

            //currentRPGSystem = rpgSystem;

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
