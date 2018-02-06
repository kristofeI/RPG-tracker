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
    public partial class MakeNewCharacterForm : Form
    {
        ICharacterRequester callingForm;
        List<PlayerModel> players = new List<PlayerModel>();

        public MakeNewCharacterForm(ICharacterRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            WireUpLists();

        }





        private bool ValidateForm()
        {
            bool output = true;

            if (characterNameValue.Text.Length == 0)
            {
                MessageBox.Show("Wpisz imię postaci.");
                output = false;
            }

            if (playerDropDown.Text.Length == 0 && playerNameValue.Text.Length == 0)
            {
                MessageBox.Show("Wybierz istniejącego gracza lub stwórz nowego.");
                output = false;
            }

            if (playerDropDown.Text.Length > 0 && playerNameValue.Text.Length > 0)
            {
                MessageBox.Show("Wybierz jedno: istniejącego gracza lub stwórz nowego.");
                output = false;
            }

            if (playerNameValue.Text.Length > 0 && !GlobalConfig.Connection.IsPlayerNameUnique(playerNameValue.Text))
            {
                MessageBox.Show("Istnieje już gracz o takim imieniu.");
                output = false;
            }

            return output;
        }

        private void WireUpLists()
        {
            playerDropDown.DataSource = null;

            playerDropDown.DataSource = GlobalConfig.Connection.GetAllPlayers();
            playerDropDown.DisplayMember = "Name";
            

            playerDropDown.SelectedIndex = -1;


        }




        private void makeCharacterAndBackButton_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {
                if (playerDropDown.Text.Length > 0 && playerNameValue.Text.Length == 0)
                {
                    CharacterModel characterModel = new CharacterModel(
                    characterNameValue.Text);

                    GlobalConfig.Connection.AddNewCharacter(characterModel);
                    callingForm.CharacterComplete(characterModel);

                    PlayerModel selectedPlayer = (PlayerModel)playerDropDown.SelectedValue;

                    selectedPlayer.PlayerCharacters.Add(characterModel);

                    GlobalConfig.Connection.UpdatePlayer(selectedPlayer);


                    this.Close();
                }
                else if (playerDropDown.Text.Length == 0 && playerNameValue.Text.Length > 0)
                {


                    CharacterModel characterModel = new CharacterModel(
                    characterNameValue.Text);


                    GlobalConfig.Connection.AddNewCharacter(characterModel);

                    callingForm.CharacterComplete(characterModel);



                    PlayerModel playerModel = new PlayerModel(
                    playerNameValue.Text,
                    playerEmailValue.Text,
                    characterModel);

                    GlobalConfig.Connection.AddNewPlayer(playerModel);

                    this.Close();

                }

            }

        }





        private void makeCharacterAndEditButton_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {
                if (playerDropDown.Text.Length > 0 && playerNameValue.Text.Length == 0)
                {
                    CharacterModel characterModel = new CharacterModel(
                    characterNameValue.Text);
                    GlobalConfig.Connection.AddNewCharacter(characterModel);
                    callingForm.CharacterComplete(characterModel);

                    PlayerModel selectedPlayer = (PlayerModel)playerDropDown.SelectedValue;
                    selectedPlayer.PlayerCharacters.Add(characterModel);
                    GlobalConfig.Connection.UpdatePlayer(selectedPlayer);

                    callingForm.EditCharacter(characterModel);

                    this.Close();
                }
                else if (playerDropDown.Text.Length == 0 && playerNameValue.Text.Length > 0)
                {


                    CharacterModel characterModel = new CharacterModel(
                    characterNameValue.Text);


                    GlobalConfig.Connection.AddNewCharacter(characterModel);

                    callingForm.EditCharacter(characterModel);



                    PlayerModel playerModel = new PlayerModel(
                    playerNameValue.Text,
                    playerEmailValue.Text,
                    characterModel);
                    GlobalConfig.Connection.AddNewPlayer(playerModel);

                    callingForm.EditCharacter(characterModel);

                    this.Close();

                }

            }
            
        }

            }
        }
