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
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;
using TrackerUI.FormRequesters;

namespace TrackerUI
{
    public partial class AddNewWeaponForm : Form
    {
        IWeaponRequester callingForm;

        public AddNewWeaponForm(IWeaponRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        

        private void addNewWeaponButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                WeaponModel model = new WeaponModel(
                    weaponNameValue.Text, 
                    ammoSupplyValue.Text);

                GlobalConfig.Connection.AddNewWeapon(model);

                callingForm.WeaponComplete(model);

                this.Close();

            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int ammoSupply = 0;
            bool ammoValidNumber = int.TryParse(ammoSupplyValue.Text, out ammoSupply);

            if (!ammoValidNumber)
            {
                MessageBox.Show("Wpisz liczbę w prawidłowym formacie w polu Amunicja.");
                output = false;
            }

            if (ammoSupply < 0)
            {
                MessageBox.Show("Wpisz liczbę w prawidłowym formacie w polu Amunicja.");
                output = false;
            }

            if (weaponNameValue.Text.Length == 0)
            {
                MessageBox.Show("Wpisz nazwę broni.");
                output = false;
            }

            if (weaponDamageValue.Text.Length == 0)
            {
                MessageBox.Show("Wpisz obrażenia broni");
                output = false;
            }

            return output;
        }
    }
}
