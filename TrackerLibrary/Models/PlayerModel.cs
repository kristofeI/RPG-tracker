using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PlayerModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public List<CharacterModel> PlayerCharacters { get; set; } = new List<CharacterModel>();

        public PlayerModel()
        {

        }

        public PlayerModel(string name, string emailAddress, CharacterModel character)
        {
            
            Name = name;
            EmailAddress = emailAddress;
            PlayerCharacters.Add(character);
        }
    }
}
