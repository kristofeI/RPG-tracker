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
    public partial class GMTrackerUI : Form
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

            NpcListBox.DataSource = currentsNpcs;
            NpcListBox.DisplayMember = "Name";
        }

        private void CreateSampleData()
        {
            currentTeam.Add(new CharacterModel { Name = "Zbyszek" });
            currentsNpcs.Add(new CharacterModel { Name = "Wiesława" });

        }
        
    }
}
