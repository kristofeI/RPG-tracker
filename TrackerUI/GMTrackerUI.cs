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
    public partial class GMTrackerUI : Form, ICharacterRequester, IEventRequester
    {

        //TODO!! wire up current session, its team and npcs
        CampaignModel currentCampaign = new CampaignModel();
        List<PlayerModel> currentPlayers = new List<PlayerModel>();
        List<CharacterModel> currentTeam = new List<CharacterModel>();
        List<CharacterModel> currentsNpcs = new List<CharacterModel>();
        List<CharacterModel> fightingUnits = new List<CharacterModel>();



        public GMTrackerUI()
        {
            InitializeComponent();

            CreateSampleData();

            WireUpLists();
        }

        private void WireUpLists()
        {

            teamListBox.DataSource = null;
            teamListBox.DataSource = currentTeam;
            teamListBox.DisplayMember = "Name";

            NpcListBox.DataSource = null;
            NpcListBox.DataSource = currentsNpcs;
            NpcListBox.DisplayMember = "Name";

            fightingUnitsListBox.DataSource = null;
            fightingUnitsListBox.DataSource = fightingUnits;
            fightingUnitsListBox.DisplayMember = "Name";

            playerListDropDown.DataSource = null;
            playerListDropDown.DataSource = currentPlayers;
            playerListDropDown.DisplayMember = "Name";

            if (playerListDropDown.SelectedText != "")
            {
                characterListDropDown.DataSource = null;
                characterListDropDown.DataSource = GlobalConfig.Connection.GetAllCharactersOfOnePlayer((PlayerModel)playerListDropDown.SelectedItem);
                characterListDropDown.DisplayMember = "Name";
            }
            
            yearValue.Text = currentCampaign.CurrentGameTime.ToString("yyyy");
            monthValue.Text = currentCampaign.CurrentGameTime.ToString("MM");
            dayValue.Text = currentCampaign.CurrentGameTime.ToString("dd");
            timeLabel.Text = currentCampaign.CurrentGameTime.ToString("HH:mm");
            
        }

        private void CreateSampleData()
        {
            currentTeam.Add(new CharacterModel { Name = "Zbyszek" });
            currentsNpcs.Add(new CharacterModel { Name = "Wiesława" });

        }

        private bool ValidateListOfCharactersButton()
        {
            bool output = true;

            if (!teamRadioButton.Checked && !npcRadioButton.Checked)
            {
                output = false;
            }
            

            return output;
        }










        private void makeNewCharacterButton_Click(object sender, EventArgs e)
        {

            if (ValidateListOfCharactersButton())
            {
                MakeNewCharacterForm frm = new MakeNewCharacterForm(this);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Zaznacz do której listy dodać postać - do drużyny czy NPC?");
            }
            


        }

        public void CharacterComplete(CharacterModel model)
        {
            //get back from the form a new CharacterModel
            //take the CharacterModel and put it into our list
            

            if (teamRadioButton.Checked)
            {
                currentTeam.Add(model);

                WireUpLists();
            }
            if (npcRadioButton.Checked)
            {
                currentsNpcs.Add(model);

                WireUpLists();
            }
            else
            {
                MessageBox.Show("Zaznacz do której listy dodać postać - do drużyny czy NPC?");
            }
        }

        public void EditCharacter(CharacterModel model)
        {
            EditCharacterForm frm = new EditCharacterForm(this, model);
            frm.Show();
        }

        private void showEditCharacterButton_Click(object sender, EventArgs e)
        {
            if (ValidateListOfCharactersButton())
            {
                if (teamRadioButton.Checked)
                {
                    EditCharacterForm frm = new EditCharacterForm(this, (CharacterModel)teamListBox.SelectedValue);
                    frm.Show();
                }
                if (npcRadioButton.Checked)
                {
                    EditCharacterForm frm = new EditCharacterForm(this, (CharacterModel)NpcListBox.SelectedValue);
                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("Zaznacz z której listy pokazać/edytować bohatera - z drużyny czy NPC?");
            }
        }

        private void addCharacterToFightButton_Click(object sender, EventArgs e)
        {
            if (ValidateListOfCharactersButton())
            {
                if (teamRadioButton.Checked)
                {
                    fightingUnits.Add((CharacterModel)teamListBox.SelectedValue);
                }
                if (npcRadioButton.Checked)
                {
                    fightingUnits.Add((CharacterModel)NpcListBox.SelectedValue);
                }
            }
            else
            {
                MessageBox.Show("Zaznacz z której listy pokazać/edytować bohatera - z drużyny czy NPC?");
            }
        }

        private void removeCharacterButton_Click(object sender, EventArgs e)
        {
            if (ValidateListOfCharactersButton())
            {
                if (teamRadioButton.Checked)
                {
                    CharacterModel c = (CharacterModel)teamListBox.SelectedValue;

                    currentTeam.Remove(c);

                    WireUpLists();
                }
                if (npcRadioButton.Checked)
                {
                    CharacterModel c = (CharacterModel)NpcListBox.SelectedValue;

                    currentsNpcs.Remove(c);

                    WireUpLists();
                }
            }
            else
            {
                MessageBox.Show("Zaznacz z której listy pokazać/edytować bohatera - z drużyny czy NPC?");
            }
        }

        private void addExistingCharacterToListButton_Click(object sender, EventArgs e)
        {
            CharacterModel model = (CharacterModel)characterListDropDown.SelectedItem;

            CharacterComplete(model);
        }

        private void playerListDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            WireUpLists();
        }










        private void changeDateButton_Click(object sender, EventArgs e)
        {
            if (ValidateChangeDateButton())
            {
                DateTime newTime = new DateTime(int.Parse(yearValue.Text), int.Parse(monthValue.Text), int.Parse(dayValue.Text)) + currentCampaign.CurrentGameTime.TimeOfDay;

                currentCampaign.CurrentGameTime = newTime;

                GlobalConfig.Connection.UpdateCampaign(currentCampaign);

                WireUpLists();
            }
        }

        private bool ValidateChangeDateButton()
        {
            bool output = true;
            int yearNumber = 0;
            int monthNumber = 0;
            int dayNumber = 0;

            int.TryParse(yearValue.Text, out yearNumber);
            int.TryParse(monthValue.Text, out monthNumber);
            int.TryParse(dayValue.Text, out dayNumber);

            if (yearNumber == 0 || monthNumber == 0 || dayNumber == 0)
            {
                MessageBox.Show("Wpisz poprawne liczby");
                output = false;
                return output;
            }

            if (yearValue.Text.Length == 0 || monthValue.Text.Length == 0 || dayValue.Text.Length == 0)
            {
                MessageBox.Show("Wpisz poprawne liczby");
                output = false;
                return output;
            }

            return output;
        }

        private void addTimeButton_Click(object sender, EventArgs e)
        {
            DateTime newTime = currentCampaign.CurrentGameTime.AddHours(1);

            currentCampaign.CurrentGameTime = newTime;

            GlobalConfig.Connection.UpdateCampaign(currentCampaign);

            foreach (CharacterModel character in currentTeam)
            {
                character.HoursWithoutDrugs += 1;
                character.HoursWithoutFood += 1;
                character.HoursWithoutWater += 1;

                GlobalConfig.Connection.UpdateCharacter(character);
            }

            WireUpLists();
        }

        private void subtractTimeButton_Click(object sender, EventArgs e)
        {
            DateTime newTime = currentCampaign.CurrentGameTime.AddHours(-1);

            currentCampaign.CurrentGameTime = newTime;

            GlobalConfig.Connection.UpdateCampaign(currentCampaign);

            foreach (CharacterModel character in currentTeam)
            {
                character.HoursWithoutDrugs -= 1;
                character.HoursWithoutFood -= 1;
                character.HoursWithoutWater -= 1;

                GlobalConfig.Connection.UpdateCharacter(character);
            }

            WireUpLists();
        }

        private void timeDescriptionButton_Click(object sender, EventArgs e)
        {
            HistoryForm frm = new HistoryForm(this, currentCampaign);
            frm.Show();
        }

        public void EventsEdited(CampaignModel model)
        {
            GlobalConfig.Connection.UpdateCampaign(model);

            WireUpLists();
        }

        private void bodyNeedsButton_Click(object sender, EventArgs e)
        {
            BodyNeedsForm frm = new BodyNeedsForm(this, currentTeam);
            frm.Show();
        }

        public void CharacterUpdate(CharacterModel model)
        {
            GlobalConfig.Connection.UpdateCharacter(model);

            WireUpLists();
        }
    }
}
