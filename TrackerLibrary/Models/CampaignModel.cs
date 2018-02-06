using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class CampaignModel
    {
        public int Id { get; set; }

        public string CampaignName { get; set; }

        public DateTime CurrentGameTime { get; set; }

        public List<PlayerModel> PlayersInCampaign { get; set; } = new List<PlayerModel>();

        public List<CharacterModel> TeamCharacters { get; set; } = new List<CharacterModel>();

        public List<CharacterModel> NpcCharacters { get; set; } = new List<CharacterModel>();

        public List<CharacterModel> FightingUnits { get; set; } = new List<CharacterModel>();

        public List<EventModel> Events { get; set; } = new List<EventModel>();
    }
}
