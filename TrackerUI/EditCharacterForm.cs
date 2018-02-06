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
    public partial class EditCharacterForm: Form, IWeaponRequester
    {
        ICharacterRequester callingForm;
        CharacterModel currentCharacter = new CharacterModel();
        List<SkillModel> currentCharacterSkills = new List<SkillModel>();
        List<WeaponModel> currentCharacterWeapons = new List<WeaponModel>();
        List<ItemModel> currentCharacterItems = new List<ItemModel>();
        List<string> dices = new List<string>() { "k4", "k6", "k8", "k10", "k12" };
        List<string> traits = new List<string>() { "Duch", "Siła", "Spryt", "Wigor", "Zręczność"};

        public EditCharacterForm(ICharacterRequester caller, CharacterModel character)
        {
            InitializeComponent();

            callingForm = caller;

            currentCharacter = character;

            //CreateSampleData();

            WireUpLists();
        }

        private void CreateSampleData()
        {
            currentCharacterSkills.Add(new SkillModel { Name = "Tropienie", Dice = "k6", Trait = "Spryt" });
            currentCharacterSkills.Add(new SkillModel { Name = "Rzucanie", Dice = "k8", Trait = "Siła" });

        }

        private void WireUpLists()
        {

            currentCharacterSkills = currentCharacter.CharacterSkills;
            currentCharacterWeapons = currentCharacter.CharacterWeapons;
            currentCharacterItems = currentCharacter.Items;
            
            characterNameTextBox.Text = currentCharacter.Name;
            characterOriginTextbox.Text = currentCharacter.Origin;
            characterCurrentLocationTextbox.Text = currentCharacter.CurrentLocation;
            characterProfessionTextBox.Text = currentCharacter.Profession;
            characterIllnessTextbox.Text = currentCharacter.Illness;
            characterCharacteristicsTextbox.Text = currentCharacter.Characteristics;
            characterReputationTextBox.Text = Convert.ToString(currentCharacter.Reputation);
            characterFameTextBox.Text = Convert.ToString(currentCharacter.Fame);
            characterTricksTextbox.Text = currentCharacter.Trick;

            levelTextBox.Text = Convert.ToString(currentCharacter.Level);
            experienceTextbox.Text = Convert.ToString(currentCharacter.Experience);
            tempoTextbox.Text = Convert.ToString(currentCharacter.Tempo);
            defenseTextbox.Text = Convert.ToString(currentCharacter.Defence);
            enduranceTextbox.Text = Convert.ToString(currentCharacter.Endurance);
            charismaTextbox.Text = Convert.ToString(currentCharacter.Charisma);
            luckTextbox.Text = Convert.ToString(currentCharacter.Luck);
            woundsTextbox.Text = Convert.ToString(currentCharacter.Wounds);
            exhaustionTextbox.Text = Convert.ToString(currentCharacter.Exhaution);
            shockTextbox.Text = Convert.ToString(currentCharacter.Shock);
            bleedingTextbox.Text = Convert.ToString(currentCharacter.Bleeding);
            illnessProgressionTextbox.Text = Convert.ToString(currentCharacter.IllnessProgression);
            hoursWithoutFoodTextBox.Text = Convert.ToString(currentCharacter.HoursWithoutFood);
            hoursWithoutWaterTextBox.Text = Convert.ToString(currentCharacter.HoursWithoutWater);
            hoursWithoutDrugsTextBox.Text = Convert.ToString(currentCharacter.HoursWithoutDrugs);

            spiritDiceDropDown.DataSource = dices;
            strengthDiceDropDown.DataSource = dices;
            cunningDiceDropDown.DataSource = dices;
            vigorDiceDropDown.DataSource = dices;
            agilityDiceDropDown.DataSource = dices;

            weaponListBox.DataSource = null;
            weaponListBox.DataSource = currentCharacterWeapons;
            weaponListBox.DisplayMember = "DisplayedWeaponName";

            addedItemsListBox.DataSource = null;
            addedItemsListBox.DataSource = currentCharacterItems;
            addedItemsListBox.DisplayMember = "DisplayedItemName";

            skillsListBox.DataSource = null;
            skillsListBox.DataSource = currentCharacterSkills;
            skillsListBox.DisplayMember = "Name";

            skillTraitDropDown.DataSource = traits;
            skillDiceDropDown.DataSource = dices;


        }
        

        private void addNewSkillButton_Click(object sender, EventArgs e)
        {
            if (ValidateaddNewSkillButton())
            {
                SkillModel skill = new SkillModel(
                    skillNameValue.Text,
                    skillTraitDropDown.Text,
                    skillDiceDropDown.Text);

                GlobalConfig.Connection.AddNewSkill(skill);

                currentCharacterSkills.Add(skill);

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

        private bool ValidateaddNewSkillButton()
        {
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
            SkillModel s = (SkillModel)skillsListBox.SelectedItem;

            currentCharacterSkills.Remove(s);

            WireUpLists();
        }

        private void addNewWeaponButton_Click(object sender, EventArgs e)
        {
            AddNewWeaponForm frm = new AddNewWeaponForm(this);
            frm.Show();
        }

        public void WeaponComplete(WeaponModel model)
        {
            currentCharacter.CharacterWeapons.Add(model);

            WireUpLists();
        }

        private void addNewItemButton_Click(object sender, EventArgs e)
        {
            if (ValidateItemButton())
            {
                ItemModel item = new ItemModel(
                    itemNameTextBox.Text,
                    int.Parse(itemQuantityTextBox.Text));

                GlobalConfig.Connection.AddNewItem(item);

                currentCharacter.Items.Add(item);

                itemNameTextBox.Text = "";
                itemQuantityTextBox.Text = "";

                WireUpLists();
            }

           
        }

        private bool ValidateItemButton()
        {
            bool output = true;
            int itemQuantity = 0;
            bool itemValidNumber = int.TryParse(itemQuantityTextBox.Text, out itemQuantity);

            if (!itemValidNumber)
            {
                MessageBox.Show("Wpisz prawidłową ilość sztuk przedmiotu.");
                output = false;
            }

            if (itemQuantity < 0)
            {
                MessageBox.Show("Wpisz prawidłową ilość sztuk przedmiotu.");
                output = false;
            }

            if (itemNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Wpisz prawidłową nazwę przedmiotu.");
                output = false;
            }

            return output;
        }

        private void removeSelectedItemButton_Click(object sender, EventArgs e)
        {
            ItemModel i = (ItemModel)addedItemsListBox.SelectedItem;

            currentCharacterItems.Remove(i);

            WireUpLists();
        }

        private void saveAndExitCharacterButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                currentCharacter.CharacterSkills = currentCharacterSkills;
                currentCharacter.CharacterWeapons = currentCharacterWeapons;
                currentCharacter.Items = currentCharacterItems;

                currentCharacter.Name = characterNameTextBox.Text;
                currentCharacter.Origin = characterOriginTextbox.Text;
                currentCharacter.CurrentLocation = characterCurrentLocationTextbox.Text;
                currentCharacter.Profession = characterProfessionTextBox.Text;
                currentCharacter.Illness = characterIllnessTextbox.Text;
                currentCharacter.Characteristics = characterCharacteristicsTextbox.Text;
                currentCharacter.Reputation = int.Parse(characterReputationTextBox.Text);
                currentCharacter.Fame = int.Parse(characterFameTextBox.Text);
                currentCharacter.Trick = characterTricksTextbox.Text;

                currentCharacter.Level = int.Parse(levelTextBox.Text);
                currentCharacter.Experience = int.Parse(experienceTextbox.Text);
                currentCharacter.Tempo = int.Parse(tempoTextbox.Text);
                currentCharacter.Defence = int.Parse(defenseTextbox.Text);
                currentCharacter.Endurance = int.Parse(enduranceTextbox.Text);
                currentCharacter.Charisma = int.Parse(charismaTextbox.Text);
                currentCharacter.Luck = int.Parse(luckTextbox.Text);
                currentCharacter.Wounds = int.Parse(woundsTextbox.Text);
                currentCharacter.Exhaution = int.Parse(exhaustionTextbox.Text);
                currentCharacter.Shock = int.Parse(shockTextbox.Text);
                currentCharacter.Bleeding = int.Parse(bleedingTextbox.Text);
                currentCharacter.IllnessProgression = int.Parse(illnessProgressionTextbox.Text);
                currentCharacter.HoursWithoutFood = int.Parse(hoursWithoutFoodTextBox.Text);
                currentCharacter.HoursWithoutWater = int.Parse(hoursWithoutWaterTextBox.Text);
                currentCharacter.HoursWithoutDrugs = int.Parse(hoursWithoutDrugsTextBox.Text);

                GlobalConfig.Connection.UpdateCharacter(currentCharacter);

                this.Close();



            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int validNumber = 0;
            string[] textArray = new string[] {
                characterReputationTextBox.Text,
                characterFameTextBox.Text,
                levelTextBox.Text,
                experienceTextbox.Text,
                tempoTextbox.Text,
                defenseTextbox.Text,
                enduranceTextbox.Text,
                charismaTextbox.Text,
                luckTextbox.Text, 
                woundsTextbox.Text,
                exhaustionTextbox.Text,
                shockTextbox.Text,
                bleedingTextbox.Text,
                illnessProgressionTextbox.Text,
                hoursWithoutFoodTextBox.Text,
                hoursWithoutWaterTextBox.Text,
                hoursWithoutDrugsTextBox.Text
            };

            foreach (string text in textArray)
            {
                if (!int.TryParse(text, out validNumber))
                {
                    MessageBox.Show("Wpisz liczby w prawidłowym formacie.");
                    output = false;
                    return output;
                }
            }

            

            if (characterNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Wpisz imię postaci.");
                output = false;
                return output;
            }

            return output;
        }
    }
}
