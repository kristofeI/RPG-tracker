using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string WeaponsFile = "WeaponModels.csv";
        private const string SkillsFile = "SkillModels.csv";
        private const string PlayersFile = "PlayerModels.csv";
        private const string CharactersFile = "CharacterModels.csv";
        private const string SessionsFile = "SessionsModels.csv";

        public SkillModel AddNewSkill(SkillModel model)
        {
            List<SkillModel> skills = SkillsFile.FullFilePath().LoadFile().ConvertToSkillModels();

            int currentId = 1;

            if (skills.Count > 0)
            {
                currentId = skills.Max(x => x.Id) + 1;
            }

            model.Id = currentId;

            skills.Add(model);

            skills.SaveToSkillsFile(SkillsFile);

            return model;
        }


        public WeaponModel AddNewWeapon(WeaponModel model)
        {
            List<WeaponModel> weapons = WeaponsFile.FullFilePath().LoadFile().ConvertToWeaponModels();
            
            int currentId = 1;

            if (weapons.Count > 0)
            {
                currentId = weapons.Max(x => x.Id) + 1;
            }

            model.Id = currentId;
            
            weapons.Add(model);
            
            weapons.SaveToWeaponsFile(WeaponsFile);

            return model;
        }

        public PlayerModel AddNewPlayer(PlayerModel model)
        {
            List<PlayerModel> players = PlayersFile.FullFilePath().LoadFile().ConvertToPlayerModels(CharactersFile, WeaponsFile, SkillsFile);

            int currentId = 1;

            if (players.Count > 0)
            {
                currentId = players.Max(x => x.Id) + 1;
            }

            model.Id = currentId;

            players.Add(model);

            players.SaveToPlayersFile(PlayersFile);

            return model;
        }

        public CharacterModel AddNewCharacter(CharacterModel model)
        {
            List<CharacterModel> characters = CharactersFile.FullFilePath().LoadFile().ConvertToCharacterModels(WeaponsFile, SkillsFile);

            int currentId = 1;

            if (characters.Count > 0)
            {
                currentId = characters.Max(x => x.Id) + 1;
            }

            model.Id = currentId;

            characters.Add(model);

            characters.SaveToCharactersFile(CharactersFile);

            return model;
        }

        public SessionModel AddNewSession(SessionModel model)
        {
            List<SessionModel> sessions = SessionsFile.FullFilePath().LoadFile().ConvertToSessionModels(PlayersFile, CharactersFile, WeaponsFile, SkillsFile);


            int currentId = 1;

            if (sessions.Count > 0)
            {
                currentId = sessions.Max(x => x.Id) + 1;
            }

            model.Id = currentId;

            sessions.Add(model);

            sessions.SaveToSessionsFile(SessionsFile);

            return model;

        }


        public List<SkillModel> GetAllSkillsOfOneCharacter(CharacterModel character)
        {
            List<SkillModel> skills = character.CharacterSkills;

            return skills;
        }

        public List<PlayerModel> GetAllPlayers()
        {
            List<PlayerModel> players = PlayersFile.FullFilePath().LoadFile().ConvertToPlayerModels(CharactersFile, WeaponsFile, SkillsFile);

            return players;
        }

        
    }
}
