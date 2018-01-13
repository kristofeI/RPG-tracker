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
    public partial class MakeNewCharacterForm : Form
    {

        public MakeNewCharacterForm()
        {
            InitializeComponent();
            
        }

        //TODO - Source data for combobox

        

        //private void addNewPlayerButton_Click(object sender, EventArgs e)
        //{
        //    if (ValidateAddNewPlayerButton())
        //    {
        //        PlayerModel model = new PlayerModel(
        //            playerNameValue.Text,
        //            playerEmailValue.Text);

        //        GlobalConfig.Connection.AddNewPlayer(model);

        //        playerNameValue.Text = "";
        //        playerEmailValue.Text = "";
        //    }
           

        //    else
        //    {
        //        MessageBox.Show("Fomularz zawiera nieprawidłowe informacje");
        //    }
        //}

        //private bool ValidateAddNewPlayerButton()
        //{
        //    bool output = true;

        //    if (playerNameValue.Text.Length == 0)
        //    {
        //        output = false;
        //    }

        //    return output;
        //}

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
            
            return output;
        }

        private void makeCharacterOnlyButton_Click(object sender, EventArgs e)
        {
            //TODO - make a character//Validate the form, make a model(only name, player and id), save the model, clear out the form
            if (ValidateForm())
            {
                if (playerDropDown.Text.Length > 0 && playerNameValue.Text.Length == 0)
                {
                    //TODO - change static player id depending on player drop donw or newly made player

                    CharacterModel model = new CharacterModel(
                    characterNameValue.Text);

                    GlobalConfig.Connection.AddNewCharacter(model);

                    characterNameValue.Text = "";
                    playerDropDown.Text = "";
                }
                else if (playerDropDown.Text.Length == 0 && playerNameValue.Text.Length > 0)
                {


                    CharacterModel characterModel = new CharacterModel(
                    characterNameValue.Text);


                    GlobalConfig.Connection.AddNewCharacter(characterModel);

                    characterNameValue.Text = "";
                    playerNameValue.Text = "";


                    PlayerModel playerModel = new PlayerModel(
                    playerNameValue.Text,
                    playerEmailValue.Text,
                    characterModel);

                    GlobalConfig.Connection.AddNewPlayer(playerModel);

                    playerNameValue.Text = "";
                    playerEmailValue.Text = "";

                    //TODO - change static player id depending on player drop donw or newly made player

                    
                }
                
            }

            //TODO - pop up the messagebox and return to the menu

        }

        private void makeCharacterAndEditButton_Click(object sender, EventArgs e)
        {
            //TODO - make a character//Validate the form, make a model(only name, player and id), save the model, clear out the form
            //TODO - proceed to the form 'edit character'
        }
    }
}
