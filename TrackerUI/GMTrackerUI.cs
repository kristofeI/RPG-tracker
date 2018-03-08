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
    public partial class GMTrackerUI : Form, ICharacterRequester, ICampaignRequester
    {
        CampaignModel currentCampaign = new CampaignModel();
        List<CharacterModel> fightingUnits = new List<CharacterModel>();
        ICampaignRequester callingForm;

        public GMTrackerUI(ICampaignRequester caller, CampaignModel campaign)
        {
            InitializeComponent();

            callingForm = caller;
            currentCampaign = campaign;

            WireUpLists();
        }

        private void WireUpLists()
        {

            teamListBox.DataSource = null;
            teamListBox.DataSource = currentCampaign.TeamCharacters;
            teamListBox.DisplayMember = "Name";

            NpcListBox.DataSource = null;
            NpcListBox.DataSource = currentCampaign.NpcCharacters;
            NpcListBox.DisplayMember = "Name";

            fightingUnitsListBox.DataSource = null;
            fightingUnitsListBox.DataSource = fightingUnits;
            fightingUnitsListBox.DisplayMember = "Name";

            playerListDropDown.DataSource = null;
            playerListDropDown.DataSource = currentCampaign.PlayersInCampaign;
            playerListDropDown.DisplayMember = "Name";

            if (playerListDropDown.Text != "")
            {
                characterListDropDown.DataSource = null;
                characterListDropDown.DataSource = GlobalConfig.Connection.GetAllCharactersOfOnePlayer((PlayerModel)playerListDropDown.SelectedItem);
                characterListDropDown.DisplayMember = "Name";
                characterListDropDown.SelectedIndex = -1;
            }

            yearValue.Text = currentCampaign.CurrentGameTime.ToString("yyyy");
            monthValue.Text = currentCampaign.CurrentGameTime.ToString("MM");
            dayValue.Text = currentCampaign.CurrentGameTime.ToString("dd");
            timeLabel.Text = currentCampaign.CurrentGameTime.ToString("HH:mm");
            
        }

        private void CreateSampleData()
        {
            currentCampaign.TeamCharacters.Add(new CharacterModel { Name = "Zbyszek" });
            currentCampaign.NpcCharacters.Add(new CharacterModel { Name = "Wiesława" });

        }

        private bool ValidateListOfCharactersButton()
        {
            bool output = true;

            if (!teamRadioButton.Checked && !npcRadioButton.Checked)
            {
                MessageBox.Show("Zaznacz z której listy pokazać/edytować postać - z drużyny czy NPC?");
                output = false;
            }


            return output;
        }

        private bool ValidateListOfCharactersToEditButton()
        {
            bool output = true;

            if (!teamRadioButton.Checked && !npcRadioButton.Checked)
            {
                MessageBox.Show("Zaznacz z której listy pokazać/edytować postać - z drużyny czy NPC?");
                output = false;
            }
            if (teamRadioButton.Checked && teamListBox.Items.Count == 0)
            {
                MessageBox.Show("Na liście nie ma żadnej postaci do pokazania/edycji. ");
                output = false;
            }
            if (npcRadioButton.Checked && NpcListBox.Items.Count == 0)
            {
                MessageBox.Show("Na liście nie ma żadnej postaci do pokazania/edycji. ");
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
            if (teamRadioButton.Checked)
            {
                currentCampaign.TeamCharacters.Add(model);

                callingForm.CampaignEdited(currentCampaign);

                WireUpLists();
            }
            if (npcRadioButton.Checked)
            {
                currentCampaign.NpcCharacters.Add(model);

                callingForm.CampaignEdited(currentCampaign);

                WireUpLists();
            }
            if (!teamRadioButton.Checked && !npcRadioButton.Checked)
            {
                MessageBox.Show("Zaznacz z której listy pokazać/edytować postać - z drużyny czy NPC?");
            }
        }

        public void EditCharacter(CharacterModel model)
        {
            EditCharacterForm frm = new EditCharacterForm(this, model);
            frm.Show();
        }

        private void showEditCharacterButton_Click(object sender, EventArgs e)
        {
            if (ValidateListOfCharactersToEditButton())
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
        }

        private void addCharacterToFightButton_Click(object sender, EventArgs e)
        {
            if (ValidateListOfCharactersButton())
            {
                if (teamRadioButton.Checked)
                {
                    fightingUnits.Add((CharacterModel)teamListBox.SelectedValue);

                    WireUpLists();
                }
                if (npcRadioButton.Checked)
                {
                    fightingUnits.Add((CharacterModel)NpcListBox.SelectedValue);

                    WireUpLists();
                }
            }
            else
            {
                MessageBox.Show("Zaznacz z której listy dodać do walki - z drużyny czy NPC?");
            }
        }

        private void removeCharacterButton_Click(object sender, EventArgs e)
        {
            if (ValidateListOfCharactersButton())
            {
                if (teamRadioButton.Checked)
                {
                    CharacterModel c = (CharacterModel)teamListBox.SelectedValue;

                    currentCampaign.TeamCharacters.Remove(c);

                    callingForm.CampaignEdited(currentCampaign);

                    WireUpLists();
                }
                if (npcRadioButton.Checked)
                {
                    CharacterModel c = (CharacterModel)NpcListBox.SelectedValue;

                    currentCampaign.NpcCharacters.Remove(c);

                    callingForm.CampaignEdited(currentCampaign);

                    WireUpLists();
                }
            }
            else
            {
                MessageBox.Show("Zaznacz z której listy usunąć bohatera - z drużyny czy NPC?");
            }
        }

        private void addExistingCharacterToListButton_Click(object sender, EventArgs e)
        {
            CharacterModel model = (CharacterModel)characterListDropDown.SelectedItem;

            if (model != null)
            {
                if (CheckIfCharacterIsAlreadyOnTheList(model))
                {
                    CharacterComplete(model);
                } 
            }
            else
                MessageBox.Show("Nie została wybrana postać do dodania.");
        }

        private void playerListDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            WireUpLists();
        }

        private bool CheckIfCharacterIsAlreadyOnTheList(CharacterModel characterToCheck)
        {
            bool output = true;

            foreach (CharacterModel character in currentCampaign.NpcCharacters)
            {
                if (characterToCheck.Id == character.Id)
                {
                    output = false;
                    MessageBox.Show("Postać już istnieje na liście NPCów.");
                } 
            }

            foreach (CharacterModel character in currentCampaign.TeamCharacters)
            {
                if (characterToCheck.Id == character.Id)
                {
                    output = false;
                    MessageBox.Show("Postać już istnieje na liście drużyny.");
                }
            }

            return output;
        }



        private void changeDateButton_Click(object sender, EventArgs e)
        {
            if (ValidateChangeDateButton())
            {
                DateTime newTime = new DateTime(int.Parse(yearValue.Text), int.Parse(monthValue.Text), int.Parse(dayValue.Text)) + currentCampaign.CurrentGameTime.TimeOfDay;

                currentCampaign.CurrentGameTime = newTime;

                callingForm.CampaignEdited(currentCampaign);

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

            callingForm.CampaignEdited(currentCampaign);

            foreach (CharacterModel character in currentCampaign.TeamCharacters)
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

            callingForm.CampaignEdited(currentCampaign);

            foreach (CharacterModel character in currentCampaign.TeamCharacters)
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

        public void CampaignEdited(CampaignModel model)
        {
            GlobalConfig.Connection.UpdateCampaign(model);

            WireUpLists();
        }

        private void bodyNeedsButton_Click(object sender, EventArgs e)
        {
            BodyNeedsForm frm = new BodyNeedsForm(this, currentCampaign.TeamCharacters);
            frm.Show();
        }

        public void CharacterUpdate(CharacterModel model)
        {
            GlobalConfig.Connection.UpdateCharacter(model);

            WireUpLists();
        }

        public void NewPlayerCreated(PlayerModel model)
        {
            currentCampaign.PlayersInCampaign.Add(model);

            GlobalConfig.Connection.UpdateCampaign(currentCampaign);

            WireUpLists();
        }







        private void removeSelectedFightUnitsButton_Click(object sender, EventArgs e)
        {
            CharacterModel c = (CharacterModel)fightingUnitsListBox.SelectedValue;

            fightingUnits.Remove(c);

            WireUpLists();
        }

        private void startFightButton_Click(object sender, EventArgs e)
        {
            BattleForm frm = new BattleForm(this, fightingUnits);
            frm.Show();
        }
    }
}
