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

namespace TrackerUI
{
    public partial class HistoryForm : Form
    {
        CampaignModel currentCampaign = new CampaignModel();

        public HistoryForm()
        {
            InitializeComponent();
        }

        private void WireUpLists()
        {
            timeLabel.Text = currentCampaign.CurrentGameTime.ToString("yyyy-MM-dd HH:mm");

        }

        private void addNewEventButton_Click(object sender, EventArgs e)
        {
            EventModel newEvent = new EventModel(currentCampaign.CurrentGameTime, timeDescriptionTextBox.Text);

            GlobalConfig.Connection.AddNewEvent(newEvent);
        }
    }
}
