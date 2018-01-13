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

namespace TrackerUI
{
    public partial class AddNewWeaponForm : Form
    {
        public AddNewWeaponForm()
        {
            InitializeComponent();
        }

        

        private void addNewWeaponButton_Click(object sender, EventArgs e)
        {
            //Validate the form, make a model , save the model, clear out the form
            if (ValidateForm())
            {
                //TODO - Make a proper initialization of new weapon
                WeaponModel model = new WeaponModel(
                    weaponNameValue.Text, 
                    ammoSupplyValue.Text);

                GlobalConfig.Connection.AddNewWeapon(model);

                weaponNameValue.Text = "";
                ammoSupplyValue.Text = "";

            }

            else
            {
                MessageBox.Show("Formularz zawiera nieprawidłowe informacje");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int ammoSupply = 0;
            bool ammoValidNumber = int.TryParse(ammoSupplyValue.Text, out ammoSupply);

            if (!ammoValidNumber)
            {
                output = false;
            }

            if (ammoSupply < 0)
            {
                output = false;
            }

            if (weaponNameValue.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }
    }
}
