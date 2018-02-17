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
            charactersInBattleListBox.SelectedIndex = -1;

            selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;

            cardDropDown.DisplayMember = "Text";
            cardDropDown.ValueMember = "Value";
            var cardsArray = new[] {
                    new { Text = "1", Value = "1" },
                    new { Text = "2", Value = "2" },
                    new { Text = "3", Value = "3" },
                    new { Text = "4", Value = "4" },
                    new { Text = "5", Value = "5" },
                    new { Text = "7", Value = "6" },
                    new { Text = "8", Value = "8" },
                    new { Text = "9", Value = "9" },
                    new { Text = "10", Value = "10" },
                    new { Text = "Walet", Value = "Walet" },
                    new { Text = "Dama", Value = "Dama" },
                    new { Text = "Król", Value = "Król" },
                    new { Text = "As", Value = "As" },
                    new { Text = "Joker", Value = "Joker" }
                };
            cardDropDown.DataSource = cardsArray;
            cardDropDown.SelectedIndex = -1;

            colorDropDown.DisplayMember = "Text";
            colorDropDown.ValueMember = "Value";
            var colorsArray = new[] {
                    new { Text = "pik", Value = "pik" },
                    new { Text = "kier", Value = "kier" },
                    new { Text = "karo", Value = "karo" },
                    new { Text = "trefl", Value = "trefl" }
                };
            colorDropDown.DataSource = colorsArray;
            colorDropDown.SelectedIndex = -1;

            woundsValueDropDown.DisplayMember = "Text";
            woundsValueDropDown.ValueMember = "Value";
            var woundsArray = new[] {
                    new { Text = "0", Value = "0" },
                    new { Text = "-1", Value = "-1" },
                    new { Text = "-2", Value = "-2" },
                    new { Text = "-3", Value = "-3" }
                };
            woundsValueDropDown.DataSource = woundsArray;
            woundsValueDropDown.SelectedIndex = -1;

            exhaustionValueDropDown.DisplayMember = "Text";
            exhaustionValueDropDown.ValueMember = "Value";
            var exhaustionArray = new[] {
                    new { Text = "0", Value = "0" },
                    new { Text = "-1", Value = "-1" },
                    new { Text = "-2", Value = "-2" }
                };
            exhaustionValueDropDown.DataSource = exhaustionArray;
            exhaustionValueDropDown.SelectedIndex = -1;

            shockValueDropDown.DisplayMember = "Text";
            shockValueDropDown.ValueMember = "Value";
            var shockArray = new[] {
                    new { Text = "Tak", Value = "Tak" },
                    new { Text = "Nie", Value = "Nie" }
                };
            shockValueDropDown.DataSource = shockArray;
            shockValueDropDown.SelectedIndex = -1;

            bleedingValueDropDown.DisplayMember = "Text";
            bleedingValueDropDown.ValueMember = "Value";
            var bleedingArray = new[] {
                    new { Text = "Tak", Value = "Tak" },
                    new { Text = "Nie", Value = "Nie" }
                };
            bleedingValueDropDown.DataSource = bleedingArray;
            bleedingValueDropDown.SelectedIndex = -1;

            actionThisRoundDropDown.DisplayMember = "Text";
            actionThisRoundDropDown.ValueMember = "Value";
            var actionArray = new[] {
                    new { Text = "Wstrzymanie akcji", Value = "Wstrzymanie akcji" },
                    new { Text = "Przerwanie czyjejś akcji", Value = "Przerwanie czyjejś akcji" },
                    new { Text = "Walka wręcz", Value = "Walka wręcz" },
                    new { Text = "Walka na dystans", Value = "Walka na dystans" }
                };
            actionThisRoundDropDown.DataSource = actionArray;
            actionThisRoundDropDown.SelectedIndex = -1;
        }

        private void RefreshLists()
        {
            selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;

            charactersInBattleListBox.DataSource = null;
            charactersInBattleListBox.DataSource = fightingCharacters;
            charactersInBattleListBox.DisplayMember = "DisplayedFightingCharacter";
            charactersInBattleListBox.SelectedItem = selectedCharacter;

            if (selectedCharacter != null && charactersInBattleListBox.SelectedIndex != -1)
            {
                weaponDropDown.DataSource = null;
                if (selectedCharacter.CharacterWeapons != null)
                {
                    weaponDropDown.DataSource = selectedCharacter.CharacterWeapons;
                    weaponDropDown.DisplayMember = "DisplayedWeaponName";
                    if (selectedCharacter.CurrentWeapon != null)
                        weaponDropDown.SelectedItem = selectedCharacter.CurrentWeapon;
                }

                skillsListBox.DataSource = null;
                if (selectedCharacter.CharacterSkills != null)
                    skillsListBox.DataSource = selectedCharacter.CharacterSkills;
                skillsListBox.DisplayMember = "DisplayedSkillName";

                //cardDropDown.DisplayMember = "Text";
                //cardDropDown.ValueMember = "Value";
                //var cardsArray = new[] {
                //    new { Text = "1", Value = "1" },
                //    new { Text = "2", Value = "2" },
                //    new { Text = "3", Value = "3" },
                //    new { Text = "4", Value = "4" },
                //    new { Text = "5", Value = "5" },
                //    new { Text = "7", Value = "6" },
                //    new { Text = "8", Value = "8" },
                //    new { Text = "9", Value = "9" },
                //    new { Text = "10", Value = "10" },
                //    new { Text = "Walet", Value = "Walet" },
                //    new { Text = "Dama", Value = "Dama" },
                //    new { Text = "Król", Value = "Król" },
                //    new { Text = "As", Value = "As" },
                //    new { Text = "Joker", Value = "Joker" }
                //};
                //cardDropDown.DataSource = cardsArray;
                if (selectedCharacter.Card != null)
                    cardDropDown.SelectedValue = selectedCharacter.Card;

                //colorDropDown.DisplayMember = "Text";
                //colorDropDown.ValueMember = "Value";
                //var colorsArray = new[] {
                //    new { Text = "pik", Value = "pik" },
                //    new { Text = "kier", Value = "kier" },
                //    new { Text = "karo", Value = "karo" },
                //    new { Text = "trefl", Value = "trefl" }
                //};
                //colorDropDown.DataSource = colorsArray;
                if (selectedCharacter.Color != null)
                    colorDropDown.SelectedValue = selectedCharacter.Color;

                //woundsValueDropDown.DisplayMember = "Text";
                //woundsValueDropDown.ValueMember = "Value";
                //var woundsArray = new[] {
                //    new { Text = "0", Value = "0" },
                //    new { Text = "-1", Value = "-1" },
                //    new { Text = "-2", Value = "-2" },
                //    new { Text = "-3", Value = "-3" }
                //};
                //woundsValueDropDown.DataSource = woundsArray;
                woundsValueDropDown.SelectedValue = Convert.ToString(selectedCharacter.Wounds);

                //exhaustionValueDropDown.DisplayMember = "Text";
                //exhaustionValueDropDown.ValueMember = "Value";
                //var exhaustionArray = new[] {
                //    new { Text = "0", Value = "0" },
                //    new { Text = "-1", Value = "-1" },
                //    new { Text = "-2", Value = "-2" }
                //};
                //exhaustionValueDropDown.DataSource = exhaustionArray;
                exhaustionValueDropDown.SelectedValue = Convert.ToString(selectedCharacter.Exhaution);

                //shockValueDropDown.DisplayMember = "Text";
                //shockValueDropDown.ValueMember = "Value";
                //var shockArray = new[] {
                //    new { Text = "Tak", Value = "Tak" },
                //    new { Text = "Nie", Value = "Nie" }
                //};
                //shockValueDropDown.DataSource = shockArray;
                if (selectedCharacter.Shock != null)
                    shockValueDropDown.SelectedValue = selectedCharacter.Shock;

                //bleedingValueDropDown.DisplayMember = "Text";
                //bleedingValueDropDown.ValueMember = "Value";
                //var bleedingArray = new[] {
                //    new { Text = "Tak", Value = "Tak" },
                //    new { Text = "Nie", Value = "Nie" }
                //};
                //bleedingValueDropDown.DataSource = bleedingArray;
                if (selectedCharacter.Bleeding != null)
                    bleedingValueDropDown.SelectedValue = selectedCharacter.Bleeding;

                //actionThisRoundDropDown.DisplayMember = "Text";
                //actionThisRoundDropDown.ValueMember = "Value";
                //var actionArray = new[] {
                //    new { Text = "Wstrzymanie akcji", Value = "Wstrzymanie akcji" },
                //    new { Text = "Przerwanie czyjejś akcji", Value = "Przerwanie czyjejś akcji" },
                //    new { Text = "Walka wręcz", Value = "Walka wręcz" },
                //    new { Text = "Walka na dystans", Value = "Walka na dystans" }
                //};
                //actionThisRoundDropDown.DataSource = actionArray;
                if (selectedCharacter.Action != null)
                    actionThisRoundDropDown.SelectedValue = selectedCharacter.Action;
                
                tempoValueLabel.Text = Convert.ToString(selectedCharacter.Tempo);
                defenseValueLabel.Text = Convert.ToString(selectedCharacter.Defence);
                enduranceValueLabel.Text = Convert.ToString(selectedCharacter.Endurance);
                charismaValueLabel.Text = Convert.ToString(selectedCharacter.Charisma);
            }

        }

        private void charactersInBattleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charactersInBattleListBox.SelectedIndex != -1)
            {
                RefreshLists(); 
            }
        }

        private void addRoundButton_Click(object sender, EventArgs e)
        {
            foreach (CharacterModel character in charactersInBattleListBox.Items)
            {
                character.Card = null;
                character.Color = null;
                character.Action = null;
                callingForm.CharacterUpdate(character);
            }

            int roundNumber = int.Parse(actualRoundValueLabel.Text);

            roundNumber++;

            actualRoundValueLabel.Text = Convert.ToString(roundNumber);

            WireUpLists();
        }

        private void cardDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charactersInBattleListBox.SelectedIndex != -1)
            {
                CharacterModel selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;
                if (cardDropDown.SelectedIndex != -1)
                {
                    selectedCharacter.Card = cardDropDown.Text;
                    RefreshLists();
                }

                
            }
        }

        private void colorDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charactersInBattleListBox.SelectedIndex != -1)
            {
                CharacterModel selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;
                if (colorDropDown.SelectedIndex != -1)
                {
                    selectedCharacter.Color = colorDropDown.Text;
                    RefreshLists();
                }

                
            }
        }

        private void actionThisRoundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charactersInBattleListBox.SelectedIndex != -1)
            {
                CharacterModel selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;

                if (actionThisRoundDropDown.SelectedIndex != -1)
                {
                    selectedCharacter.Action = actionThisRoundDropDown.Text;
                    RefreshLists();
                }

                
            }
        }

        private void woundsValueDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charactersInBattleListBox.SelectedIndex != -1)
            {
                CharacterModel selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;
                if (woundsValueDropDown.SelectedIndex != -1)
                {
                    selectedCharacter.Wounds = float.Parse(woundsValueDropDown.Text);
                    RefreshLists();
                }

                
            }
        }

        private void exhaustionValueDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charactersInBattleListBox.SelectedIndex != -1)
            {
                CharacterModel selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;
                if (exhaustionValueDropDown.SelectedIndex != -1)
                {
                    selectedCharacter.Exhaution = float.Parse(exhaustionValueDropDown.Text);
                    RefreshLists();
                }

                
            }
        }

        private void shockValueDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charactersInBattleListBox.SelectedIndex != -1)
            {
                CharacterModel selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;
                if (shockValueDropDown.SelectedIndex != -1)
                {
                    selectedCharacter.Shock = shockValueDropDown.Text;
                    RefreshLists();
                }

                
            }
        }

        private void bleedingValueDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charactersInBattleListBox.SelectedIndex != -1)
            {
                CharacterModel selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;
                if (bleedingValueDropDown.SelectedIndex != -1)
                {
                    selectedCharacter.Bleeding = bleedingValueDropDown.Text;
                    RefreshLists();
                }

                
            }
        }

        private void weaponDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charactersInBattleListBox.SelectedIndex != -1)
            {
                CharacterModel selectedCharacter = (CharacterModel)charactersInBattleListBox.SelectedItem;
                if (weaponDropDown.SelectedIndex != -1)
                {
                    selectedCharacter.CurrentWeapon = (WeaponModel)weaponDropDown.SelectedItem;
                    RefreshLists();
                }
            }
        }

        private void changeStatsAndBackButton_Click(object sender, EventArgs e)
        {
            foreach (CharacterModel character in charactersInBattleListBox.Items)
            {
                character.Card = null;
                character.Color = null;
                character.Action = null;
                callingForm.CharacterUpdate(character);
            }

            this.Close();
        }

        private void BattleForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
