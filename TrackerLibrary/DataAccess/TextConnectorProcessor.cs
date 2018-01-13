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

        public static List<PlayerModel> ConvertToPlayerModels(this List<string> lines, string charactersFileName, string weaponsFileName, string skillsFileName)
        {
            List<PlayerModel> output = new List<PlayerModel>();
            List<CharacterModel> characters = charactersFileName.FullFilePath().LoadFile().ConvertToCharacterModels(weaponsFileName, skillsFileName);

            foreach (string line in lines)
            {
                string[] cols = line.Split('#');

                PlayerModel p = new PlayerModel();
                p.Id = int.Parse(cols[0]);
                p.Name = cols[1];
                p.EmailAddress = cols[2];

                string[] characterIds = cols[3].Split('|');

                foreach (string id in characterIds)
                {
                    p.PlayerCharacters.Add(characters.Where(x => x.Id == int.Parse(id)).First());
                }

                output.Add(p);
            }

            return output;
        }

        public static List<CharacterModel> ConvertToCharacterModels(this List<string> lines, string weaponsFileName, string skillsFileName)
        {
            List<CharacterModel> output = new List<CharacterModel>();
            List<WeaponModel> weapons = weaponsFileName.FullFilePath().LoadFile().ConvertToWeaponModels();
            List<SkillModel> skills = skillsFileName.FullFilePath().LoadFile().ConvertToSkillModels();

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
                c.Shock = float.Parse(cols[20]);
                c.Bleeding = float.Parse(cols[21]);
                c.IllnessProgression = float.Parse(cols[22]);
                c.Hunger = float.Parse(cols[23]);
                c.Thirst = float.Parse(cols[24]);
                c.NeedForDrugs = float.Parse(cols[25]);
                c.IsCharacterInTeam = bool.Parse(cols[26]);

                string[] weaponIds = cols[27].Split('|');

                foreach (string id in weaponIds)
                {
                    c.CharacterWeapons.Add(weapons.Where(x => x.Id == int.Parse(id)).First());
                }

                string[] skillIds = cols[28].Split('|');

                foreach (string id in skillIds)
                {
                    c.CharacterSkills.Add(skills.Where(x => x.Id == int.Parse(id)).First());
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


        public static List<SessionModel> ConvertToSessionModels(this List<string> lines, string playersFileName, string charactersFileName, string weaponsFileName, string skillsFileName)
        {
            List<SessionModel> output = new List<SessionModel>();
            List<PlayerModel> players = playersFileName.FullFilePath().LoadFile().ConvertToPlayerModels(charactersFileName, weaponsFileName, skillsFileName);
            List<CharacterModel> teamCharacters = charactersFileName.FullFilePath().LoadFile().ConvertToCharacterModels(weaponsFileName, skillsFileName);
            List<CharacterModel> npcCharacters = charactersFileName.FullFilePath().LoadFile().ConvertToCharacterModels(weaponsFileName, skillsFileName);

            foreach (string line in lines)
            {
                string[] cols = line.Split('#');

                SessionModel s = new SessionModel();

                s.Id = int.Parse(cols[0]);
                s.Name = cols[1];

                string[] playerIds = cols[2].Split('|');
                foreach (string id in playerIds)
                {
                    s.PlayersInSession.Add(players.Where(x => x.Id == int.Parse(id)).First());
                }

                string[] teamCharactersIds = cols[3].Split('|');
                foreach (string id in teamCharactersIds)
                {
                    s.TeamCharacters.Add(teamCharacters.Where(x => x.Id == int.Parse(id)).First());
                }

                string[] npcCharactersIds = cols[4].Split('|');
                foreach (string id in npcCharactersIds)
                {
                    s.NpcCharacters.Add(npcCharacters.Where(x => x.Id == int.Parse(id)).First());
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
                    $"{ c.Id }#{ c.Name }#{ c.Origin }#{ c.CurrentLocation }#{ c.Profession }#{ c.Illness }#{ c.Characteristics }#{ c.Trick }#{ c.Reputation }#{ c.Fame }#{ c.Luck }#{ c.Level }#{ c.Experience }#{ c.ExpReward }#{ c.Tempo }#{ c.Defence }#{ c.Endurance }#{ c.Charisma }#{ c.Wounds }#{ c.Exhaution }#{ c.Shock }#{ c.Bleeding }#{ c.IllnessProgression }#{ c.Hunger }#{ c.Thirst }#{ c.NeedForDrugs }#{ c.IsCharacterInTeam }#{ ConvertIdsFromWeaponListToString(c.CharacterWeapons) }#{ ConvertIdsFromSkillListToString(c.CharacterSkills) }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToWeaponsFile(this List<WeaponModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (WeaponModel w in models)
            {
                lines.Add($"{ w.Id }#{ w.WeaponName }#{ w.AmmoSupply }");
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

        public static void SaveToSessionsFile(this List<SessionModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (SessionModel s in models)
            {
                lines.Add($"{ s.Id }#{ s.Name }#{ ConvertIdsFromPlayerListToString(s.PlayersInSession) }#{ ConvertIdsFromCharacterListToString(s.TeamCharacters) }#{ ConvertIdsFromCharacterListToString(s.NpcCharacters) }");
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

        private static string ConvertIdsFromSessionListToString(List<SessionModel> sessions)
        {
            string output = "";

            if (sessions.Count == 0)
            {
                return "";
            }

            foreach (SessionModel s in sessions)
            {
                output += $"{ s.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }


        #endregion




    }
}
