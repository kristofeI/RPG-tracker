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

        public float Hunger { get; set; }

        public float Thirst { get; set; }

        public float NeedForDrugs { get; set; }

        public bool IsCharacterInTeam { get; set; }

        public List<WeaponModel> CharacterWeapons { get; set; } = new List<WeaponModel>();

        public List<SkillModel> CharacterSkills { get; set; } = new List<SkillModel>();

        public CharacterModel()
        {

        }

        public CharacterModel(string name)
        {
            Name = name;
            IsCharacterInTeam = false;
        }

//        public CharacterModel()
//        {
//            Name
//Player
//Origin
//CurrentLocation
//Profession
//Illness
//Characteristics
//Trick
//Reputation
//Fame
//Luck
//Level
//Experience
//ExpReward
//Tempo
//Defence
//Endurance
//Charisma
//Wounds
//Exhaution
//Shock
//Bleeding
//IllnessProgression
//Hunger
//Thirst
//NeedForDrugs
//        }

    }

}
