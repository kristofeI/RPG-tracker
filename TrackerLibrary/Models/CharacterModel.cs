using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class CharacterModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Origin { get; set; }

        public string CurrentLocation { get; set; }

        public string Profession { get; set; }

        public string Illness { get; set; }

        public string Characteristics { get; set; }

        public string Trick { get; set; }

        public float Reputation { get; set; }

        public float Fame { get; set; }

        public float Luck { get; set; }

        public float Level { get; set; }

        public float Experience { get; set; }

        public float ExpReward { get; set; }

        public float Tempo { get; set; }

        public float Defence { get; set; }

        public float Endurance { get; set; }

        public float Charisma { get; set; }

        public float Wounds { get; set; }

        public float Exhaution { get; set; }

        public float Shock { get; set; }

        public float Bleeding { get; set; }

        public float IllnessProgression { get; set; }

        public float HoursWithoutFood { get; set; }

        public float HoursWithoutWater { get; set; }

        public float HoursWithoutDrugs { get; set; }

        public bool IsCharacterInTeam { get; set; }

        public List<WeaponModel> CharacterWeapons { get; set; } = new List<WeaponModel>();

        public List<SkillModel> CharacterSkills { get; set; } = new List<SkillModel>();

        public List<ItemModel> Items { get; set; } = new List<ItemModel>();

        public CharacterModel()
        {

        }

        public CharacterModel(string name)
        {
            Name = name;
            IsCharacterInTeam = false;
        }


    }

}
