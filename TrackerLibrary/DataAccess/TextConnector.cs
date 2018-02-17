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
        public void AddNewSkill(SkillModel model)
        {
            List<SkillModel> skills = GlobalConfig.SkillsFile.FullFilePath().LoadFile().ConvertToSkillModels();

            int currentId = 1;

            if (skills.Count > 0)
            {
                currentId = skills.Max(x => x.Id) + 1;
            }
            

            model.Id = currentId;

            skills.Add(model);

            skills.SaveToSkillsFile();
        }

        public void AddNewItem(ItemModel model)
        {
            List<ItemModel> items = GlobalConfig.ItemsFile.FullFilePath().LoadFile().ConvertToItemModels();

            int currentId = 1;

            if (items.Count > 0)
            {
                currentId = items.Max(x => x.Id) + 1;
            }


            model.Id = currentId;

            items.Add(model);

            items.SaveToItemsFile();
        }


        public void AddNewWeapon(WeaponModel model)
        {
            List<WeaponModel> weapons = GlobalConfig.WeaponsFile.FullFilePath().LoadFile().ConvertToWeaponModels();
            
            int currentId = 1;

            if (weapons.Count > 0)
            {
                currentId = weapons.Max(x => x.Id) + 1;
            }

            model.Id = currentId;
            
            weapons.Add(model);
            
            weapons.SaveToWeaponsFile();
        }

        public void AddNewPlayer(PlayerModel model)
        {
            List<PlayerModel> players = GlobalConfig.PlayersFile.FullFilePath().LoadFile().ConvertToPlayerModels();

            int currentId = 1;

            if (players.Count > 0)
            {
                currentId = players.Max(x => x.Id) + 1;
            }

            model.Id = currentId;

            players.Add(model);

            players.SaveToPlayersFile();
        }

        public void AddNewCharacter(CharacterModel model)
        {
            List<CharacterModel> characters = GlobalConfig.CharactersFile.FullFilePath().LoadFile().ConvertToCharacterModels();

            int currentId = 1;

            if (characters.Count > 0)
            {
                currentId = characters.Max(x => x.Id) + 1;
            }

            model.Id = currentId;

            characters.Add(model);

            characters.SaveToCharactersFile();
        }


        public void AddNewRPGSystem(RPGSystemModel model)
        {
            List<RPGSystemModel> rpgSystems = GlobalConfig.RPGSystemsFile.FullFilePath().LoadFile().ConvertToRPGSystemModels();

            int currentId = 1;

            if (rpgSystems.Count > 0)
            {
                currentId = rpgSystems.Max(x => x.Id) + 1;
            }

            model.Id = currentId;

            rpgSystems.Add(model);

            rpgSystems.SaveToRPGSystemFile();
        }

        public void AddNewCampaign(CampaignModel model)
        {
            List<CampaignModel> campaigns = GlobalConfig.CampaignsFile.FullFilePath().LoadFile().ConvertToCampaignModels();


            int currentId = 1;

            if (campaigns.Count > 0)
            {
                currentId = campaigns.Max(x => x.Id) + 1;
            }

            model.Id = currentId;

            campaigns.Add(model);

            campaigns.SaveToCampaignFile();

        }

        public void AddNewEvent(EventModel model)
        {
            List<EventModel> events = GlobalConfig.EventsFile.FullFilePath().LoadFile().ConvertToEventModels();

            int currentId = 1;

            if (events.Count > 0)
            {
                currentId = events.Max(x => x.Id) + 1;
            }


            model.Id = currentId;

            events.Add(model);

            events.SaveToEventsFile();
        }






        public void UpdateEvent(EventModel model)
        {
            List<EventModel> events = GlobalConfig.EventsFile.FullFilePath().LoadFile().ConvertToEventModels();

            EventModel eventToReplace = events.First(x => x.Id == model.Id);
            var index = events.IndexOf(eventToReplace);
            if (index != -1)
            {
                events[index] = model;
            }

            if (GlobalConfig.EventsFile.FullFilePath().DeleteFile())
            {
                events.SaveToEventsFile();
            }
        }

        public void UpdatePlayer(PlayerModel model)
        {
            List<PlayerModel> players = GlobalConfig.PlayersFile.FullFilePath().LoadFile().ConvertToPlayerModels();

            PlayerModel playerToReplace = players.First(x => x.Id == model.Id);
            var index = players.IndexOf(playerToReplace);
            if (index != -1)
            {
                players[index] = model;
            }

            if (GlobalConfig.PlayersFile.FullFilePath().DeleteFile())
            {
                players.SaveToPlayersFile();
            }
        }

        public void UpdateCharacter(CharacterModel model)
        {
            List<CharacterModel> characters = GlobalConfig.CharactersFile.FullFilePath().LoadFile().ConvertToCharacterModels();

            CharacterModel characterToReplace = characters.First(x => x.Id == model.Id);
            var index = characters.IndexOf(characterToReplace);
            if (index != -1)
            {
                characters[index] = model;
            }

            if (GlobalConfig.CharactersFile.FullFilePath().DeleteFile())
            {
                characters.SaveToCharactersFile();
            }
        }

        public void UpdateCampaign(CampaignModel model)
        {
            List<CampaignModel> campaigns = GlobalConfig.CampaignsFile.FullFilePath().LoadFile().ConvertToCampaignModels();

            CampaignModel campaignToReplace = campaigns.First(x => x.Id == model.Id);
            var index = campaigns.IndexOf(campaignToReplace);
            if (index != -1)
            {
                campaigns[index] = model;
            }

            if (GlobalConfig.CampaignsFile.FullFilePath().DeleteFile())
            {
                campaigns.SaveToCampaignFile();
            }
        }

        public void UpdateRPGSystem(RPGSystemModel model)
        {
            List<RPGSystemModel> rpgSystems = GlobalConfig.RPGSystemsFile.FullFilePath().LoadFile().ConvertToRPGSystemModels();

            RPGSystemModel rpgSystemToReplace = rpgSystems.First(x => x.Id == model.Id);
            var index = rpgSystems.IndexOf(rpgSystemToReplace);
            if (index != -1)
            {
                rpgSystems[index] = model;
            }

            if (GlobalConfig.RPGSystemsFile.FullFilePath().DeleteFile())
            {
                rpgSystems.SaveToRPGSystemFile();
            }
        }







        




        public List<SkillModel> GetAllSkillsOfOneCharacter(CharacterModel character)
        {
            List<SkillModel> skills = character.CharacterSkills;

            return skills;
        }

        public List<PlayerModel> GetAllPlayers()
        {
            List<PlayerModel> players = GlobalConfig.PlayersFile.FullFilePath().LoadFile().ConvertToPlayerModels();

            return players;
        }

        public bool IsPlayerNameUnique(string playerName)
        {
            bool output = true;

            List<PlayerModel> names = new List<PlayerModel>();
            List<PlayerModel> players = GlobalConfig.PlayersFile.FullFilePath().LoadFile().ConvertToPlayerModels();

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
            List<CampaignModel> campaigns = GlobalConfig.CampaignsFile.FullFilePath().LoadFile().ConvertToCampaignModels();

            return campaigns;
        }


        public RPGSystemModel GetRPGSystem(RPGSystemModel rpgSystem)
        {
            List<RPGSystemModel> rpgSystems = GlobalConfig.RPGSystemsFile.FullFilePath().LoadFile().ConvertToRPGSystemModels();

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
            List<RPGSystemModel> rpgSystems = GlobalConfig.RPGSystemsFile.FullFilePath().LoadFile().ConvertToRPGSystemModels();

            return rpgSystems;
        }

        public List<RPGSystemModel> MakeProperListOfRpgSystems(List<RPGSystemModel> defaultRpgSystems)
        {
            List<RPGSystemModel> rpgSystems = GlobalConfig.RPGSystemsFile.FullFilePath().LoadFile().ConvertToRPGSystemModels();

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
