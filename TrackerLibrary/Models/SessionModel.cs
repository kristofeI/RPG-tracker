using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class SessionModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<PlayerModel> PlayersInSession { get; set; } = new List<PlayerModel>();

        public List<CharacterModel> TeamCharacters { get; set; } = new List<CharacterModel>();

        public List<CharacterModel> NpcCharacters { get; set; } = new List<CharacterModel>();
    }
}
