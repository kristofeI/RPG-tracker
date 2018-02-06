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
using TrackerUI.FormRequesters;

namespace TrackerUI
{
    public partial class BodyNeedsForm : Form
    {
        List<CharacterModel> currentTeam = new List<CharacterModel>();
        ICharacterRequester callingForm;

        public BodyNeedsForm(ICharacterRequester caller, List<CharacterModel> characters)
        {
            InitializeComponent();

            callingForm = caller;
            currentTeam = characters;

            WireUpLists();
        }

        private void WireUpLists()
        {
            pickCharacterDropDown.DataSource = null;
            pickCharacterDropDown.DataSource = currentTeam;
            pickCharacterDropDown.DisplayMember = "DisplayedCharacter";

            if (pickCharacterDropDown.SelectedText != "")
            {
                hoursWithoutDrugsLabel.Text = Convert.ToString(((CharacterModel)pickCharacterDropDown.SelectedItem).HoursWithoutDrugs);
                hoursWithoutFoodLabel.Text = Convert.ToString(((CharacterModel)pickCharacterDropDown.SelectedItem).HoursWithoutFood);
                hoursWithoutWaterLabel.Text = Convert.ToString(((CharacterModel)pickCharacterDropDown.SelectedItem).HoursWithoutWater);
            }

        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pickCharacterDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            WireUpLists();
        }

        private void updateBodyNeedsButton_Click(object sender, EventArgs e)
        {
            int value = 0;

            if (int.TryParse(hoursWithoutDrugsNewValueTextBox.Text, out value))
            {
                ((CharacterModel)pickCharacterDropDown.SelectedItem).HoursWithoutDrugs = int.Parse(hoursWithoutDrugsNewValueTextBox.Text);
                ((CharacterModel)pickCharacterDropDown.SelectedItem).HoursWithoutFood = int.Parse(hoursWithoutFoodNewValueTextBox.Text);
                ((CharacterModel)pickCharacterDropDown.SelectedItem).HoursWithoutWater = int.Parse(hoursWithoutWaterNewValueTextBox.Text);

                callingForm.CharacterUpdate((CharacterModel)pickCharacterDropDown.SelectedItem);
            }
            else
            {
                MessageBox.Show("Wpisz poprawne liczby");
            }
        }
    }
}
