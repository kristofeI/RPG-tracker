using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class GMTrackerUI : Form, ICharacterRequester
    {

        //TODO!! wire up current session, its team and npcs
        SessionModel currentSession = new SessionModel();
        List<CharacterModel> currentTeam = new List<CharacterModel>();
        List<CharacterModel> currentsNpcs = new List<CharacterModel>();
        
         

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
                MessageBox.Show("Zaznacz do której listy dodać postać.");
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
        }
    }
}
