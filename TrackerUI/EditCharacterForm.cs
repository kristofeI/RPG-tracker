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
    public partial class EditCharacterForm: Form
    {
        //TODO!!! wire up current character and his skills
        CharacterModel currentCharacter = new CharacterModel();
        List<SkillModel> addedSkills = new List<SkillModel>();
        List<string> dices = new List<string>() { "k4", "k6", "k8", "k10", "k12" };
        List<string> traits = new List<string>() { "Duch", "Siła", "Spryt", "Wigor", "Zręczność"};

        public EditCharacterForm()
        {
            InitializeComponent();

            CreateSampleData();

            WireUpLists();
        }

        private void CreateSampleData()
        {
            addedSkills.Add(new SkillModel { Name = "Tropienie", Dice = "k6", Trait = "Spryt" });
            addedSkills.Add(new SkillModel { Name = "Rzucanie", Dice = "k8", Trait = "Siła" });

        }

        private void WireUpLists()
        {
            skillsListBox.DataSource = null;

            skillsListBox.DataSource = addedSkills;
            skillsListBox.DisplayMember = "DisplayedSkillName";

            skillTraitDropDown.DataSource = traits;

            skillDiceDropDown.DataSource = dices;

        }
        

        private void addNewSkillButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SkillModel skill = new SkillModel(
                    skillNameValue.Text,
                    skillTraitDropDown.Text,
                    skillDiceDropDown.Text);

                GlobalConfig.Connection.AddNewSkill(skill);

                addedSkills.Add(skill);

                skillNameValue.Text = "";
                skillTraitDropDown.Text = "";
                skillDiceDropDown.Text = "";

                WireUpLists();
            }
            else
            {
                MessageBox.Show("Wszystkie pola muszą być uzupełnione.");
            }


        }

        private bool ValidateForm()
        {
            //TODO - Add validation to the form
            if (skillNameValue.Text.Length == 0)
            {
                return false;
            }

            if (skillTraitDropDown.Text.Length == 0)
            {
                return false;
            }

            if (skillDiceDropDown.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void removeSkillButton_Click(object sender, EventArgs e)
        {
            //example how to remove items from the list
            SkillModel s = (SkillModel)skillsListBox.SelectedItem;

            addedSkills.Remove(s);

            WireUpLists();
        }
    }
}
