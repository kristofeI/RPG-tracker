using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class RoundModel
    {
        public int RoundNumber { get; set; }

        public List<CharacterModel> fightingCharacters { get; set; } = new List<CharacterModel>();

        public RoundModel()
        {

        }

        public RoundModel(int roundNumber)
        {

        }

    }
}
