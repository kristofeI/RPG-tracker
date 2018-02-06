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
    public partial class HistoryForm : Form
    {
        CampaignModel currentCampaign = new CampaignModel();
        IEventRequester callingForm;

        public HistoryForm(IEventRequester caller, CampaignModel campaign)
        {
            InitializeComponent();

            callingForm = caller;
            currentCampaign = campaign;

            WireUpLists();
        }

        private void WireUpLists()
        {
            fullDateLabel.Text = currentCampaign.CurrentGameTime.ToString("yyyy-MM-dd HH:mm");

            historyListBox.DataSource = null;
            historyListBox.DataSource = currentCampaign.Events;
            historyListBox.DisplayMember = "DisplayedEvent";
        }

        private void addNewEventButton_Click(object sender, EventArgs e)
        {
            EventModel newEvent = new EventModel(currentCampaign.CurrentGameTime, timeDescriptionTextBox.Text);

            currentCampaign.Events.Add(GlobalConfig.Connection.AddNewEvent(newEvent));

            callingForm.EventsEdited(currentCampaign);

            WireUpLists();
        }

        private void removeSelectedEventButton_Click(object sender, EventArgs e)
        {
            if (historyListBox.Items.Count != 0)
            {
                EventModel ev = (EventModel)historyListBox.SelectedValue;

                currentCampaign.Events.Remove(ev);

                callingForm.EventsEdited(currentCampaign);

                WireUpLists();
            }
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
