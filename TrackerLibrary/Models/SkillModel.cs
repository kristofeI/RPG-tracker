using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class SkillModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Dice { get; set; }

        public string Trait { get; set; }


        public SkillModel()
        {
                
        }

        public SkillModel(string name, string dice, string trait)
        {
            Name = name;
            Dice = dice;
            Trait = trait;
        }
        

        public string DisplayedSkillName
        {
            get
            {
                return $"{ Name } - { Dice } - { Trait }";
            }
        }

    }
}
