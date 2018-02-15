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
    public partial class BattleForm : Form
    {
        ICharacterRequester callingForm;
        List<RoundModel> rounds = new List<RoundModel>();
        List<CharacterModel> fightingCharacters = new List<CharacterModel>();
        CharacterModel selectedCharacter;
        List<SkillModel> skills = new List<SkillModel>();
        List<WeaponModel> weapons = new List<WeaponModel>();
        WeaponModel selectedWeapon;
        List<string> cards = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Walet", "Dama", "Król", "As", "Joker" };
        List<string> colors = new List<string>() { "pik", "kier", "karo", "trefl"};
        List<string> actions = new List<string>() { "Wstrzymanie akcji", "Przerwanie czyjejś akcji", "Walka wręcz", "Walka na dystans" };
        List<string> choice = new List<string>() { "Tak", "Nie" };
        List<string> woundValues = new List<string>() { "0", "-1", "-2", "-3" };
        List<string> exhaustionValues = new List<string>() { "0", "-1", "-2" };

        public BattleForm(ICharacterRequester caller, List<CharacterModel> characters)
        {
            InitializeComponent();

            callingForm = caller;
            fightingCharacters = characters;

            WireUpLists();
        }

        private void WireUpLists()
        {
            charactersInBattleListBox.DataSource = null;
            charactersInBattleListBox.DataSource = fightingCharacters;
            charactersInBattleListBox.DisplayMember = "DisplayedFightingCharacter";

            cardDropDown.DataSource = null;
            cardDropDown.DataSource = cards;

            colorDropDown.DataSource = null;
            colorDropDown.DataSource = colors;
        }

        private void CharacterIsSelected()
        {
            if (charactersInBattleListBox.SelectedItem != null)
            {
                selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;
                skills = selectedCharacter.CharacterSkills;
                weapons = selectedCharacter.CharacterWeapons;
                selectedWeapon = selectedCharacter.CurrentWeapon;
            }

            weaponDropDown.DataSource = null;
            weaponDropDown.DataSource = weapons;
            weaponDropDown.DisplayMember = "DisplayedWeaponName";
            weaponDropDown.SelectedItem = selectedWeapon;

            skillsListBox.DataSource = null;
            skillsListBox.DataSource = skills;
            skillsListBox.DisplayMember = "DisplayedSkillName";

            woundsValueDropDown.DataSource = null;
            woundsValueDropDown.DataSource = woundValues;

            exhaustionValueDropDown.DataSource = null;
            exhaustionValueDropDown.DataSource = exhaustionValues;

            shockValueDropDown.DataSource = null;
            shockValueDropDown.DataSource = choice;

            bleedingValueDropDown.DataSource = null;
            bleedingValueDropDown.DataSource = choice;
            
            cardDropDown.Text = selectedCharacter.Card;
            if (cardDropDown.Text == "")
                cardDropDown.SelectedIndex = -1;

            colorDropDown.Text = selectedCharacter.Color;
            if (colorDropDown.Text == "")
                colorDropDown.SelectedIndex = -1;

            actionThisRoundDropDown.Text = selectedCharacter.Action;
            if (actionThisRoundDropDown.Text == "")
                actionThisRoundDropDown.SelectedIndex = -1;

            woundsValueDropDown.Text = Convert.ToString(selectedCharacter.Wounds);
            exhaustionValueDropDown.Text = Convert.ToString(selectedCharacter.Exhaution);
            shockValueDropDown.Text = Convert.ToString(selectedCharacter.Shock);
            bleedingValueDropDown.Text = Convert.ToString(selectedCharacter.Bleeding);
            tempoValueLabel.Text = Convert.ToString(selectedCharacter.Tempo);
            defenseValueLabel.Text = Convert.ToString(selectedCharacter.Defence);
            enduranceValueLabel.Text = Convert.ToString(selectedCharacter.Endurance);
            charismaValueLabel.Text = Convert.ToString(selectedCharacter.Charisma);

            //if (selectedWeapon != null)
            //    damageValueLabel.Text = Convert.ToString(selectedWeapon.Damage);
            //if (selectedWeapon != null)
            //    ammoValueLabel.Text = Convert.ToString(selectedWeapon.AmmoSupply);

        }

        private void charactersInBattleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterIsSelected();
        }

        private void addRoundButton_Click(object sender, EventArgs e)
        {
            foreach (CharacterModel character in fightingCharacters)
            {
                character.Card = "";
                character.Color = "";
                character.Action = "";
            }

            int roundNumber = int.Parse(actualRoundValueLabel.Text);

            roundNumber++;

            actualRoundValueLabel.Text = Convert.ToString(roundNumber);

            CharacterIsSelected();
        }

        private void cardDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterModel selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;
            if (cardDropDown.SelectedText != "")
                selectedCharacter.Card = cardDropDown.SelectedText;
            callingForm.CharacterUpdate(selectedCharacter);
            CharacterIsSelected();
        }

        private void colorDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterModel selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;
            if (colorDropDown.SelectedText != "")
                selectedCharacter.Color = colorDropDown.SelectedText;
            callingForm.CharacterUpdate(selectedCharacter);
            CharacterIsSelected();
        }

        private void actionThisRoundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterModel selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;
            selectedCharacter.Action = actionThisRoundDropDown.SelectedText;
            callingForm.CharacterUpdate(selectedCharacter);
            CharacterIsSelected();
        }

        private void woundsValueDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterModel selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;
            if (woundsValueDropDown.SelectedText != "")
                selectedCharacter.Wounds = float.Parse(woundsValueDropDown.SelectedText);
            callingForm.CharacterUpdate(selectedCharacter);
            CharacterIsSelected();
        }

        private void exhaustionValueDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterModel selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;
            if (exhaustionValueDropDown.SelectedText != "")
                selectedCharacter.Exhaution = float.Parse(exhaustionValueDropDown.SelectedText);
            callingForm.CharacterUpdate(selectedCharacter);
            CharacterIsSelected();
        }

        private void shockValueDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterModel selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;
            if (shockValueDropDown.SelectedText != "")
                selectedCharacter.Shock = shockValueDropDown.SelectedText;
            callingForm.CharacterUpdate(selectedCharacter);
            CharacterIsSelected();
        }

        private void bleedingValueDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterModel selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;
            if (bleedingValueDropDown.SelectedText != "")
                selectedCharacter.Bleeding = bleedingValueDropDown.SelectedText;
            callingForm.CharacterUpdate(selectedCharacter);
            CharacterIsSelected();
        }

        private void weaponDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterModel selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;
            if (weaponDropDown.SelectedItem != null)
                selectedCharacter.CurrentWeapon = (WeaponModel)weaponDropDown.SelectedItem;
            callingForm.CharacterUpdate(selectedCharacter);
            CharacterIsSelected();
        }
    }
}
