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
        List<string> choice = new List<string>() { "Tak", "Nie" };
        List<string> woundValues = new List<string>() { "0", "-1", "-2", "-3" };
        List<string> exhaustionValues = new List<string>() { "0", "-1", "-2" };


        public EditCharacterForm(ICharacterRequester caller, CharacterModel character)
        {
            InitializeComponent();

            callingForm = caller;

            currentCharacter = character;

            //CreateSampleData();

            WireUpLists();

            WireUpSkillItemsAndWeaponList();
        }

        private void CreateSampleData()
        {
            currentCharacterSkills.Add(new SkillModel { Name = "Tropienie", Dice = "k6", Trait = "Spryt" });
            currentCharacterSkills.Add(new SkillModel { Name = "Rzucanie", Dice = "k8", Trait = "Siła" });

        }

        private void WireUpLists()
        {

            if (currentCharacter != null)
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
                illnessProgressionTextbox.Text = Convert.ToString(currentCharacter.IllnessProgression);
                hoursWithoutFoodTextBox.Text = Convert.ToString(currentCharacter.HoursWithoutFood);
                hoursWithoutWaterTextBox.Text = Convert.ToString(currentCharacter.HoursWithoutWater);
                hoursWithoutDrugsTextBox.Text = Convert.ToString(currentCharacter.HoursWithoutDrugs);

                spiritDiceDropDown.DisplayMember = "Text";
                spiritDiceDropDown.ValueMember = "Value";
                var spiritArray = new[] {
                    new { Text = "k4", Value = "k4" },
                    new { Text = "k6", Value = "k6" },
                    new { Text = "k8", Value = "k8" },
                    new { Text = "k10", Value = "k10" },
                    new { Text = "k12", Value = "k12" }
                };
                spiritDiceDropDown.DataSource = spiritArray;
                if (currentCharacter.Spirit != null)
                    spiritDiceDropDown.SelectedValue = currentCharacter.Spirit;
                
                strengthDiceDropDown.DisplayMember = "Text";
                strengthDiceDropDown.ValueMember = "Value";
                var strengthArray = new[] {
                    new { Text = "k4", Value = "k4" },
                    new { Text = "k6", Value = "k6" },
                    new { Text = "k8", Value = "k8" },
                    new { Text = "k10", Value = "k10" },
                    new { Text = "k12", Value = "k12" }
                };
                strengthDiceDropDown.DataSource = strengthArray;
                if (currentCharacter.Strength != null)
                    strengthDiceDropDown.SelectedValue = currentCharacter.Strength;

                cunningDiceDropDown.DisplayMember = "Text";
                cunningDiceDropDown.ValueMember = "Value";
                var cunningArray = new[] {
                    new { Text = "k4", Value = "k4" },
                    new { Text = "k6", Value = "k6" },
                    new { Text = "k8", Value = "k8" },
                    new { Text = "k10", Value = "k10" },
                    new { Text = "k12", Value = "k12" }
                };
                cunningDiceDropDown.DataSource = cunningArray;
                if (currentCharacter.Cunning != null)
                    cunningDiceDropDown.SelectedValue = currentCharacter.Cunning;

                vigorDiceDropDown.DisplayMember = "Text";
                vigorDiceDropDown.ValueMember = "Value";
                var vigorArray = new[] {
                    new { Text = "k4", Value = "k4" },
                    new { Text = "k6", Value = "k6" },
                    new { Text = "k8", Value = "k8" },
                    new { Text = "k10", Value = "k10" },
                    new { Text = "k12", Value = "k12" }
                };
                vigorDiceDropDown.DataSource = vigorArray;
                if (currentCharacter.Vigor != null)
                    vigorDiceDropDown.SelectedValue = currentCharacter.Vigor;

                agilityDiceDropDown.DisplayMember = "Text";
                agilityDiceDropDown.ValueMember = "Value";
                var agilityArray = new[] {
                    new { Text = "k4", Value = "k4" },
                    new { Text = "k6", Value = "k6" },
                    new { Text = "k8", Value = "k8" },
                    new { Text = "k10", Value = "k10" },
                    new { Text = "k12", Value = "k12" }
                };
                agilityDiceDropDown.DataSource = agilityArray;
                if (currentCharacter.Agility != null)
                    agilityDiceDropDown.SelectedValue = currentCharacter.Agility;




                woundsDropDown.DisplayMember = "Text";
                woundsDropDown.ValueMember = "Value";
                var woundsArray = new[] {
                    new { Text = "0", Value = "0" },
                    new { Text = "-1", Value = "-1" },
                    new { Text = "-2", Value = "-2" },
                    new { Text = "-3", Value = "-3" }
                };
                woundsDropDown.DataSource = woundsArray;
                woundsDropDown.SelectedValue = Convert.ToString(currentCharacter.Wounds);

                exhaustionDropDown.DisplayMember = "Text";
                exhaustionDropDown.ValueMember = "Value";
                var exhaustionArray = new[] {
                    new { Text = "0", Value = "0" },
                    new { Text = "-1", Value = "-1" },
                    new { Text = "-2", Value = "-2" }
                };
                exhaustionDropDown.DataSource = exhaustionArray;
                exhaustionDropDown.SelectedValue = Convert.ToString(currentCharacter.Exhaution);

                shockDropDown.DisplayMember = "Text";
                shockDropDown.ValueMember = "Value";
                var shockArray = new[] {
                    new { Text = "Tak", Value = "Tak" },
                    new { Text = "Nie", Value = "Nie" }
                };
                shockDropDown.DataSource = shockArray;
                if (currentCharacter.Shock != null)
                    shockDropDown.SelectedValue = currentCharacter.Shock;

                bleedingDropDown.DisplayMember = "Text";
                bleedingDropDown.ValueMember = "Value";
                var bleedingArray = new[] {
                    new { Text = "Tak", Value = "Tak" },
                    new { Text = "Nie", Value = "Nie" }
                };
                bleedingDropDown.DataSource = bleedingArray;
                if (currentCharacter.Bleeding != null)
                    bleedingDropDown.SelectedValue = currentCharacter.Bleeding;
            }
        }

        private void WireUpSkillItemsAndWeaponList()
        {
            if (currentCharacter != null)
            {
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

                WireUpSkillItemsAndWeaponList();
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

            WireUpSkillItemsAndWeaponList();
        }

        private void addNewWeaponButton_Click(object sender, EventArgs e)
        {
            AddNewWeaponForm frm = new AddNewWeaponForm(this);
            frm.Show();
        }

        public void WeaponComplete(WeaponModel model)
        {
            currentCharacter.CharacterWeapons.Add(model);

            WireUpSkillItemsAndWeaponList();
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

                WireUpSkillItemsAndWeaponList();
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

            WireUpSkillItemsAndWeaponList();
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
                currentCharacter.Wounds = int.Parse(woundsDropDown.Text);
                currentCharacter.Exhaution = int.Parse(exhaustionDropDown.Text);
                currentCharacter.Shock = shockDropDown.Text;
                currentCharacter.Bleeding = bleedingDropDown.Text;
                currentCharacter.IllnessProgression = int.Parse(illnessProgressionTextbox.Text);
                currentCharacter.HoursWithoutFood = int.Parse(hoursWithoutFoodTextBox.Text);
                currentCharacter.HoursWithoutWater = int.Parse(hoursWithoutWaterTextBox.Text);
                currentCharacter.HoursWithoutDrugs = int.Parse(hoursWithoutDrugsTextBox.Text);

                currentCharacter.Spirit = spiritDiceDropDown.Text;
                currentCharacter.Strength = strengthDiceDropDown.Text;
                currentCharacter.Cunning = cunningDiceDropDown.Text;
                currentCharacter.Vigor = vigorDiceDropDown.Text;
                currentCharacter.Agility = agilityDiceDropDown.Text;

                callingForm.CharacterUpdate(currentCharacter);

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
                woundsDropDown.Text,
                exhaustionDropDown.Text,
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

        private void weaponListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCharacter.CurrentWeapon = (WeaponModel)weaponListBox.SelectedItem;

            WireUpSkillItemsAndWeaponList();
        }

        private void removeWeaponButton_Click(object sender, EventArgs e)
        {
            WeaponModel w = (WeaponModel)weaponListBox.SelectedItem;

            currentCharacterWeapons.Remove(w);

            WireUpSkillItemsAndWeaponList();
        }

        private void justBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
