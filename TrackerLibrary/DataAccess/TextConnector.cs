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
        private const string ItemsFile = "ItemModels.csv";
        private const string PlayersFile = "PlayerModels.csv";
        private const string CharactersFile = "CharacterModels.csv";
        private const string CampaignsFile = "CampaignModels.csv";
        private const string EventsFile = "EventModels.csv";
        private const string RPGSystemsFile = "RPGSystemModels.csv";

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

        public ItemModel AddNewItem(ItemModel model)
        {
            List<ItemModel> items = ItemsFile.FullFilePath().LoadFile().ConvertToItemModels();

            int currentId = 1;

            if (items.Count > 0)
            {
                currentId = items.Max(x => x.Id) + 1;
            }


            model.Id = currentId;

            items.Add(model);

            items.SaveToItemsFile(ItemsFile);

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
            List<PlayerModel> players = PlayersFile.FullFilePath().LoadFile().ConvertToPlayerModels(CharactersFile, WeaponsFile, SkillsFile, ItemsFile);

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
            List<CharacterModel> characters = CharactersFile.FullFilePath().LoadFile().ConvertToCharacterModels(WeaponsFile, SkillsFile, ItemsFile);

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


        public RPGSystemModel AddNewRPGSystem(RPGSystemModel model)
        {
            List<RPGSystemModel> rpgSystems = RPGSystemsFile.FullFilePath().LoadFile().ConvertToRPGSystemModels(CampaignsFile, PlayersFile, CharactersFile, WeaponsFile, SkillsFile, ItemsFile, EventsFile);

            int currentId = 1;

            if (rpgSystems.Count > 0)
            {
                currentId = rpgSystems.Max(x => x.Id) + 1;
            }

            model.Id = currentId;

            rpgSystems.Add(model);

            rpgSystems.SaveToRPGSystemFile(RPGSystemsFile);

            return model;
        }

        public CampaignModel AddNewCampaign(CampaignModel model)
        {
            List<CampaignModel> campaigns = CampaignsFile.FullFilePath().LoadFile().ConvertToCampaignModels(PlayersFile, CharactersFile, WeaponsFile, SkillsFile, ItemsFile, EventsFile);


            int currentId = 1;

            if (campaigns.Count > 0)
            {
                currentId = campaigns.Max(x => x.Id) + 1;
            }

            model.Id = currentId;

            campaigns.Add(model);

            campaigns.SaveToCampaignFile(CampaignsFile);

            return model;

        }

        public EventModel AddNewEvent(EventModel model)
        {
            List<EventModel> events = EventsFile.FullFilePath().LoadFile().ConvertToEventModels();

            int currentId = 1;

            if (events.Count > 0)
            {
                currentId = events.Max(x => x.Id) + 1;
            }


            model.Id = currentId;

            events.Add(model);

            events.SaveToEventsFile(EventsFile);

            return model;
        }






        public EventModel UpdateEvent(EventModel model)
        {
            List<EventModel> events = EventsFile.FullFilePath().LoadFile().ConvertToEventModels();

            EventModel eventToReplace = events.First(x => x.Id == model.Id);
            var index = events.IndexOf(eventToReplace);
            if (index != -1)
            {
                events[index] = model;
            }

            if (EventsFile.FullFilePath().DeleteFile())
            {
                events.SaveToEventsFile(EventsFile);
            }

            return model;
        }

        public PlayerModel UpdatePlayer(PlayerModel model)
        {
            List<PlayerModel> players = PlayersFile.FullFilePath().LoadFile().ConvertToPlayerModels(CharactersFile, WeaponsFile, SkillsFile, ItemsFile);

            PlayerModel playerToReplace = players.First(x => x.Id == model.Id);
            var index = players.IndexOf(playerToReplace);
            if (index != -1)
            {
                players[index] = model;
            }

            if (PlayersFile.FullFilePath().DeleteFile())
            {
                players.SaveToPlayersFile(PlayersFile);
            }

            return model;
        }

        public CharacterModel UpdateCharacter(CharacterModel model)
        {
            List<CharacterModel> characters = CharactersFile.FullFilePath().LoadFile().ConvertToCharacterModels(WeaponsFile, SkillsFile, ItemsFile);

            CharacterModel characterToReplace = characters.First(x => x.Id == model.Id);
            var index = characters.IndexOf(characterToReplace);
            if (index != -1)
            {
                characters[index] = model;
            }

            if (CharactersFile.FullFilePath().DeleteFile())
            {
                characters.SaveToCharactersFile(CharactersFile);
            }

            return model;
        }

        public CampaignModel UpdateCampaign(CampaignModel model)
        {
            List<CampaignModel> campaigns = CampaignsFile.FullFilePath().LoadFile().ConvertToCampaignModels(PlayersFile, CharactersFile, WeaponsFile, SkillsFile, ItemsFile, EventsFile);

            CampaignModel campaignToReplace = campaigns.First(x => x.Id == model.Id);
            var index = campaigns.IndexOf(campaignToReplace);
            if (index != -1)
            {
                campaigns[index] = model;
            }

            if (CampaignsFile.FullFilePath().DeleteFile())
            {
                campaigns.SaveToCampaignFile(CampaignsFile);
            }

            return model;
        }

        public RPGSystemModel UpdateRPGSystem(RPGSystemModel model)
        {
            List<RPGSystemModel> rpgSystems = RPGSystemsFile.FullFilePath().LoadFile().ConvertToRPGSystemModels(CampaignsFile, PlayersFile, CharactersFile, WeaponsFile, SkillsFile, ItemsFile, EventsFile);

            RPGSystemModel rpgSystemToReplace = rpgSystems.First(x => x.Id == model.Id);
            var index = rpgSystems.IndexOf(rpgSystemToReplace);
            if (index != -1)
            {
                rpgSystems[index] = model;
            }

            if (RPGSystemsFile.FullFilePath().DeleteFile())
            {
                rpgSystems.SaveToRPGSystemFile(RPGSystemsFile);
            }
            
            return model;
        }







        public void AddCharacterToPlayer(CharacterModel character, PlayerModel player)
        {
            List<PlayerModel> players = PlayersFile.FullFilePath().LoadFile().ConvertToPlayerModels(CharactersFile, WeaponsFile, SkillsFile, ItemsFile);

            players.Where(x => x.Id == player.Id).First().PlayerCharacters.Add(character);

            players.SaveToPlayersFile(PlayersFile);
        }

        public void AddWeaponToCharacter(WeaponModel weapon, CharacterModel character)
        {
            List<CharacterModel> characters = CharactersFile.FullFilePath().LoadFile().ConvertToCharacterModels(WeaponsFile, SkillsFile, ItemsFile);

            characters.Where(x => x.Id == character.Id).First().CharacterWeapons.Add(weapon);

            characters.SaveToCharactersFile(CharactersFile);
        }

        public void AddSkillToCharacter(SkillModel skill, CharacterModel character)
        {
            List<CharacterModel> characters = CharactersFile.FullFilePath().LoadFile().ConvertToCharacterModels(WeaponsFile, SkillsFile, ItemsFile);

            characters.Where(x => x.Id == character.Id).First().CharacterSkills.Add(skill);

            characters.SaveToCharactersFile(CharactersFile);
        }

        public void AddItemToCharacter(ItemModel item, CharacterModel character)
        {
            List<CharacterModel> characters = CharactersFile.FullFilePath().LoadFile().ConvertToCharacterModels(WeaponsFile, SkillsFile, ItemsFile);

            characters.Where(x => x.Id == character.Id).First().Items.Add(item);

            characters.SaveToCharactersFile(CharactersFile);
        }




        public List<SkillModel> GetAllSkillsOfOneCharacter(CharacterModel character)
        {
            List<SkillModel> skills = character.CharacterSkills;

            return skills;
        }

        public List<PlayerModel> GetAllPlayers()
        {
            List<PlayerModel> players = PlayersFile.FullFilePath().LoadFile().ConvertToPlayerModels(CharactersFile, WeaponsFile, SkillsFile, ItemsFile);

            return players;
        }

        public bool IsPlayerNameUnique(string playerName)
        {
            bool output = true;

            List<PlayerModel> names = new List<PlayerModel>();
            List<PlayerModel> players = PlayersFile.FullFilePath().LoadFile().ConvertToPlayerModels(CharactersFile, WeaponsFile, SkillsFile, ItemsFile);

            names.AddRange(players.Where(x => x.Name == playerName));

            if (names.Count > 0)
            {
                output = false;
            }

            return output;

        }

        public List<CharacterModel> GetAllCharactersOfOnePlayer(PlayerModel player)
        {
            List<CharacterModel> characters = player.PlayerCharacters;

            return characters;
        }

        public List<CampaignModel> GetAllCampaigns()
        {
            List<CampaignModel> campaigns = CampaignsFile.FullFilePath().LoadFile().ConvertToCampaignModels(PlayersFile, CharactersFile, WeaponsFile, SkillsFile, ItemsFile, EventsFile);

            return campaigns;
        }


        public RPGSystemModel GetRPGSystem(RPGSystemModel rpgSystem)
        {
            List<RPGSystemModel> rpgSystems = RPGSystemsFile.FullFilePath().LoadFile().ConvertToRPGSystemModels(CampaignsFile, PlayersFile, CharactersFile, WeaponsFile, SkillsFile, ItemsFile, EventsFile);

            RPGSystemModel searchedRpgSystem = new RPGSystemModel();

            if (rpgSystems.Count == 0)
            {
                searchedRpgSystem = null;

                return searchedRpgSystem;
            }
            else
            {
                searchedRpgSystem = rpgSystems.First(x => x.SystemName == rpgSystem.SystemName);

                return searchedRpgSystem;
            }
        }

        public List<RPGSystemModel> GetAllRPGSystems()
        {
            List<RPGSystemModel> rpgSystems = RPGSystemsFile.FullFilePath().LoadFile().ConvertToRPGSystemModels(CampaignsFile, PlayersFile, CharactersFile, WeaponsFile, SkillsFile, ItemsFile, EventsFile);

            return rpgSystems;
        }

        public List<RPGSystemModel> MakeProperListOfRpgSystems(List<RPGSystemModel> defaultRpgSystems)
        {
            List<RPGSystemModel> rpgSystems = RPGSystemsFile.FullFilePath().LoadFile().ConvertToRPGSystemModels(CampaignsFile, PlayersFile, CharactersFile, WeaponsFile, SkillsFile, ItemsFile, EventsFile);

            if (rpgSystems.Count == 0)
            {
                foreach (RPGSystemModel system in defaultRpgSystems)
                {
                    GlobalConfig.Connection.AddNewRPGSystem(system);
                }

                return defaultRpgSystems;
            }
            else
            {
                return rpgSystems;
            }
        }
    }
}
