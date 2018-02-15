using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess.TextHelpers;
using TrackerLibrary.Models;

//Load the text file
//Convert the text to List<WeaponModel>
//Find the max ID
//Add the new record with the new ID (max + 1)
//Convert weapons to List<string>
//Save List<string> to the text file

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {






        public static string FullFilePath(this string FileName)
        {
            if (!Directory.Exists($@"{ ConfigurationManager.AppSettings["filePath"] }"))
            {
                Directory.CreateDirectory($@"{ ConfigurationManager.AppSettings["filePath"] }");
            }

            return $@"{ ConfigurationManager.AppSettings["filePath"] }\{ FileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }








        #region ConvertToModels

        public static List<PlayerModel> ConvertToPlayerModels(this List<string> lines, string charactersFileName, string weaponsFileName, string skillsFileName, string itemsFileName)
        {
            List<PlayerModel> output = new List<PlayerModel>();
            List<CharacterModel> characters = charactersFileName.FullFilePath().LoadFile().ConvertToCharacterModels(weaponsFileName, skillsFileName, itemsFileName);

            foreach (string line in lines)
            {
                string[] cols = line.Split('#');

                PlayerModel p = new PlayerModel();
                p.Id = int.Parse(cols[0]);
                p.Name = cols[1];
                p.EmailAddress = cols[2];

                if (characters.Count > 0)
                {

                    string[] characterIds = cols[3].Split('|');

                    foreach (string id in characterIds)
                    {
                        p.PlayerCharacters.Add(characters.Where(x => x.Id == int.Parse(id)).First());
                    }

                }
                
                output.Add(p);
            }
            

            return output;
        }

        public static List<CharacterModel> ConvertToCharacterModels(this List<string> lines, string weaponsFileName, string skillsFileName, string itemsFileName)
        {
            List<CharacterModel> output = new List<CharacterModel>();
            List<WeaponModel> weapons = weaponsFileName.FullFilePath().LoadFile().ConvertToWeaponModels();
            List<SkillModel> skills = skillsFileName.FullFilePath().LoadFile().ConvertToSkillModels();
            List<ItemModel> items = itemsFileName.FullFilePath().LoadFile().ConvertToItemModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split('#');

                CharacterModel c = new CharacterModel();

                c.Id = int.Parse(cols[0]);
                c.Name = cols[1];
                c.Origin = cols[2];
                c.CurrentLocation = cols[3];
                c.Profession = cols[4];
                c.Illness = cols[5];
                c.Characteristics = cols[6];
                c.Trick = cols[7];
                c.Reputation = float.Parse(cols[8]);
                c.Fame = float.Parse(cols[9]);
                c.Luck = float.Parse(cols[10]);
                c.Level = float.Parse(cols[11]);
                c.Experience = float.Parse(cols[12]);
                c.ExpReward = float.Parse(cols[13]);
                c.Tempo = float.Parse(cols[14]);
                c.Defence = float.Parse(cols[15]);
                c.Endurance = float.Parse(cols[16]);
                c.Charisma = float.Parse(cols[17]);
                c.Wounds = float.Parse(cols[18]);
                c.Exhaution = float.Parse(cols[19]);
                c.Shock = cols[20];
                c.Bleeding = cols[21];
                c.IllnessProgression = float.Parse(cols[22]);
                c.HoursWithoutFood = float.Parse(cols[23]);
                c.HoursWithoutWater = float.Parse(cols[24]);
                c.HoursWithoutDrugs = float.Parse(cols[25]);
                c.IsCharacterInTeam = bool.Parse(cols[26]);
                if (!(cols[27] == ""))
                {
                    c.CurrentWeapon = weapons.Where(x => x.Id == int.Parse(cols[27])).First();
                }

                if (weapons.Count > 0)
                {
                    string[] weaponIds = cols[28].Split('|');

                    
                   
                        foreach (string id in weaponIds)
                        {
                            if (!(id == ""))
                            {
                                c.CharacterWeapons.Add(weapons.Where(x => x.Id == int.Parse(id)).First());
                            }
                            
                        } 
                }


                if (skills.Count > 0)
                {
                    string[] skillIds = cols[29].Split('|');

                        foreach (string id in skillIds)
                        {
                            if (!(id == ""))
                            {
                                c.CharacterSkills.Add(skills.Where(x => x.Id == int.Parse(id)).First()); 
                            }
                        } 
                }





                if (items.Count > 0)
                {
                    string[] itemsIds = cols[30].Split('|');
                    foreach (string id in itemsIds)
                    {
                        if (!(id == ""))
                        {
                            c.Items.Add(items.Where(x => x.Id == int.Parse(id)).First());
                        }

                    } 
                }


                output.Add(c);

            }

            return output;
        }

        public static List<WeaponModel> ConvertToWeaponModels(this List<string> lines)
        {
            List<WeaponModel> output = new List<WeaponModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split('#');

                WeaponModel w = new WeaponModel();
                w.Id = int.Parse(cols[0]);
                w.WeaponName = cols[1];
                w.AmmoSupply = int.Parse(cols[2]);
                w.Damage = cols[3];
                output.Add(w);
            }

            return output;

        }

        public static List<SkillModel> ConvertToSkillModels(this List<string> lines)
        {
            List<SkillModel> output = new List<SkillModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split('#');

                SkillModel s = new SkillModel();
                s.Id = int.Parse(cols[0]);
                s.Name = cols[1];
                s.Dice = cols[2];
                s.Trait = cols[3];
                output.Add(s);
            }

            return output;
        }

        public static List<ItemModel> ConvertToItemModels(this List<string> lines)
        {
            List<ItemModel> output = new List<ItemModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split('#');

                ItemModel i = new ItemModel();
                i.Id = int.Parse(cols[0]);
                i.Name = cols[1];
                i.Quantity = int.Parse(cols[2]);
                output.Add(i);
            }

            return output;
        }

        public static List<EventModel> ConvertToEventModels(this List<string> lines)
        {
            List<EventModel> output = new List<EventModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split('#');

                EventModel e = new EventModel();
                e.Id = int.Parse(cols[0]);
                e.EventTime = DateTime.Parse(cols[1]);
                e.EventDescription = cols[2];
                output.Add(e);
            }

            return output;
        }

        public static List<RPGSystemModel> ConvertToRPGSystemModels(this List<string> lines, string campaignsFileName, string playersFileName, string charactersFileName, string weaponsFileName, string skillsFileName, string itemsFileName, string eventsFileName)
        {
            List<RPGSystemModel> output = new List<RPGSystemModel>();
            List<CampaignModel> campaigns = campaignsFileName.FullFilePath().LoadFile().ConvertToCampaignModels(playersFileName, charactersFileName, weaponsFileName, skillsFileName, itemsFileName, eventsFileName);
            List<PlayerModel> players = playersFileName.FullFilePath().LoadFile().ConvertToPlayerModels(charactersFileName, weaponsFileName, skillsFileName, itemsFileName);
            List<CharacterModel> teamCharacters = charactersFileName.FullFilePath().LoadFile().ConvertToCharacterModels(weaponsFileName, skillsFileName, itemsFileName);
            List<CharacterModel> npcCharacters = charactersFileName.FullFilePath().LoadFile().ConvertToCharacterModels(weaponsFileName, skillsFileName, itemsFileName);
            List<CharacterModel> fightingCharacters = charactersFileName.FullFilePath().LoadFile().ConvertToCharacterModels(weaponsFileName, skillsFileName, itemsFileName);
            List<EventModel> events = eventsFileName.FullFilePath().LoadFile().ConvertToEventModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split('#');

                RPGSystemModel r = new RPGSystemModel();

                r.Id = int.Parse(cols[0]);
                r.SystemName = cols[1];

                if (campaigns.Count > 0)
                {
                    string[] campaignsIds = cols[2].Split('|');

                    foreach (string id in campaignsIds)
                    {
                        if (id != "")
                        {
                            r.Campaigns.Add(campaigns.Where(x => x.Id == int.Parse(id)).First());
                        }
                    }
                }

                output.Add(r);
            }

            return output;
        }

        public static List<CampaignModel> ConvertToCampaignModels(this List<string> lines, string playersFileName, string charactersFileName, string weaponsFileName, string skillsFileName, string itemsFileName, string eventsFileName)
        {
            List<CampaignModel> output = new List<CampaignModel>();
            List<PlayerModel> players = playersFileName.FullFilePath().LoadFile().ConvertToPlayerModels(charactersFileName, weaponsFileName, skillsFileName, itemsFileName);
            List<CharacterModel> teamCharacters = charactersFileName.FullFilePath().LoadFile().ConvertToCharacterModels(weaponsFileName, skillsFileName, itemsFileName);
            List<CharacterModel> npcCharacters = charactersFileName.FullFilePath().LoadFile().ConvertToCharacterModels(weaponsFileName, skillsFileName, itemsFileName);
            List<CharacterModel> fightingCharacters = charactersFileName.FullFilePath().LoadFile().ConvertToCharacterModels(weaponsFileName, skillsFileName, itemsFileName);
            List<EventModel> events = eventsFileName.FullFilePath().LoadFile().ConvertToEventModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split('#');

                CampaignModel s = new CampaignModel();

                s.Id = int.Parse(cols[0]);
                s.CampaignName = cols[1];
                s.CurrentGameTime = DateTime.Parse(cols[2]);

                if (players.Count > 0)
                {
                    string[] playerIds = cols[3].Split('|');
                    
                        foreach (string id in playerIds)
                        {
                            if (!(id == ""))
                            {
                                s.PlayersInCampaign.Add(players.Where(x => x.Id == int.Parse(id)).First()); 
                            }
                        }  
                }

                if (teamCharacters.Count > 0)
                {
                    string[] teamCharactersIds = cols[4].Split('|');
                    
                        foreach (string id in teamCharactersIds)
                        {
                            if (!(id == ""))
                            {
                                s.TeamCharacters.Add(teamCharacters.Where(x => x.Id == int.Parse(id)).First()); 
                            }
                        }  
                }

                if (npcCharacters.Count > 0)
                {
                    string[] npcCharactersIds = cols[5].Split('|');
                    
                        foreach (string id in npcCharactersIds)
                        {
                            if (!(id == ""))
                            {
                                s.NpcCharacters.Add(npcCharacters.Where(x => x.Id == int.Parse(id)).First()); 
                            }
                        }  
                }


                if (fightingCharacters.Count > 0)
                {
                    string[] fightingCharactersIds = cols[6].Split('|');

                    foreach (string id in fightingCharactersIds)
                    {
                        if (!(id == ""))
                        {
                            s.FightingUnits.Add(fightingCharacters.Where(x => x.Id == int.Parse(id)).First());
                        }
                    }
                }

                if (events.Count > 0)
                {
                    string[] eventsIds = cols[7].Split('|');

                    foreach (string id in eventsIds)
                    {
                        if (!(id == ""))
                        {
                            s.Events.Add(events.Where(x => x.Id == int.Parse(id)).First());
                        }
                    }
                }
                output.Add(s);
            }


            return output;
        }
        
        
        #endregion













        #region SaveToFile


        public static void SaveToPlayersFile(this List<PlayerModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PlayerModel p in models)
            {
                lines.Add($"{ p.Id }#{ p.Name }#{ p.EmailAddress }#{ ConvertIdsFromCharacterListToString(p.PlayerCharacters) }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToCharactersFile(this List<CharacterModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            

            foreach (CharacterModel c in models)
            {
                lines.Add(
                    $"{ c.Id }#{ c.Name }#{ c.Origin }#{ c.CurrentLocation }#{ c.Profession }#{ c.Illness }#{ c.Characteristics }#{ c.Trick }#{ c.Reputation }#{ c.Fame }#{ c.Luck }#{ c.Level }#{ c.Experience }#{ c.ExpReward }#{ c.Tempo }#{ c.Defence }#{ c.Endurance }#{ c.Charisma }#{ c.Wounds }#{ c.Exhaution }#{ c.Shock }#{ c.Bleeding }#{ c.IllnessProgression }#{ c.HoursWithoutFood }#{ c.HoursWithoutWater }#{ c.HoursWithoutDrugs }#{ c.IsCharacterInTeam }#{ ConvertIdFromCurrentWeaponToString(c.CurrentWeapon) }#{ ConvertIdsFromWeaponListToString(c.CharacterWeapons) }#{ ConvertIdsFromSkillListToString(c.CharacterSkills) }#{ ConvertIdsFromItemListToString(c.Items) }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToWeaponsFile(this List<WeaponModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (WeaponModel w in models)
            {
                lines.Add($"{ w.Id }#{ w.WeaponName }#{ w.AmmoSupply }#{ w.Damage }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToSkillsFile(this List<SkillModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (SkillModel s in models)
            {
                lines.Add($"{ s.Id }#{ s.Name }#{ s.Dice }#{ s.Trait }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }


        public static void SaveToItemsFile(this List<ItemModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (ItemModel i in models)
            {
                lines.Add($"{ i.Id }#{ i.Name }#{ i.Quantity }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToEventsFile(this List<EventModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (EventModel e in models)
            {
                lines.Add($"{ e.Id }#{ e.EventTime }#{ e.EventDescription }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToCampaignFile(this List<CampaignModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (CampaignModel c in models)
            {
                lines.Add($"{ c.Id }#{ c.CampaignName }#{ c.CurrentGameTime }#{ ConvertIdsFromPlayerListToString(c.PlayersInCampaign) }#{ ConvertIdsFromCharacterListToString(c.TeamCharacters) }#{ ConvertIdsFromCharacterListToString(c.NpcCharacters) }#{ ConvertIdsFromCharacterListToString(c.FightingUnits) }#{ ConvertIdsFromEventListToString(c.Events) }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);

        }

        public static void  SaveToRPGSystemFile(this List<RPGSystemModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (RPGSystemModel r in models)
            {
                lines.Add($"{ r.Id }#{ r.SystemName }#{ ConvertIdsFromCampaignListToString(r.Campaigns) }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        #endregion








        #region HelperMethods

        private static string ConvertIdsFromCharacterListToString(List<CharacterModel> characters)
        {
            string output = "";

            if (characters.Count == 0)
            {
                return "";
            }

            foreach (CharacterModel c in characters)
            {
                output += $"{ c.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertIdFromCurrentWeaponToString(WeaponModel weapon)
        {
            string output = "";

            if (weapon == null)
            {
                return "";
            }

            output += $"{ weapon.Id }";

            return output;
        }

        private static string ConvertIdsFromWeaponListToString(List<WeaponModel> weapons)
        {
            string output = "";

            if (weapons.Count == 0)
            {
                return "";
            }

            foreach (WeaponModel w in weapons)
            {
                output += $"{ w.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertIdsFromSkillListToString(List<SkillModel> skills)
        {
            string output = "";

            if (skills.Count == 0)
            {
                return "";
            }

            foreach (SkillModel s in skills)
            {
                output += $"{ s.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }


        private static string ConvertIdsFromPlayerListToString(List<PlayerModel> players)
        {
            string output = "";

            if (players.Count == 0)
            {
                return "";
            }

            foreach (PlayerModel p in players)
            {
                output += $"{ p.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }
        

        private static string ConvertIdsFromCampaignListToString(List<CampaignModel> campaigns)
        {
            string output = "";

            if (campaigns.Count == 0)
            {
                return "";
            }

            foreach (CampaignModel s in campaigns)
            {
                output += $"{ s.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }




        private static string ConvertIdsFromItemListToString(List<ItemModel> items)
        {
            string output = "";

            if (items.Count == 0)
            {
                return "";
            }

            foreach (ItemModel i in items)
            {
                output += $"{ i.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }


        private static string ConvertIdsFromEventListToString(List<EventModel> events)
        {
            string output = "";

            if (events.Count == 0)
            {
                return "";
            }

            foreach (EventModel e in events)
            {
                output += $"{ e.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }





        #endregion




    }
}
