using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class WeaponModel
    {
        public int Id { get; set; }

        public string WeaponName { get; set; }

        public int AmmoSupply { get; set; }

        public string Damage { get; set; }

        public WeaponModel()
        {

        }

        public WeaponModel(string weaponName, string ammoSupply)
        {
            WeaponName = weaponName;

            int ammoSupplyValue = 0;
            int.TryParse(ammoSupply, out ammoSupplyValue);
            AmmoSupply = ammoSupplyValue;
        }

        public string DisplayedWeaponName
        {
            get
            {
                return $"{ WeaponName } - obrażenia: { Damage } - amunicja: { AmmoSupply }";
            }
        }
    }
}
