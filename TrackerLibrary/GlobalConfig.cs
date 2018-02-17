using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string WeaponsFile = "WeaponModels.csv";
        public const string SkillsFile = "SkillModels.csv";
        public const string ItemsFile = "ItemModels.csv";
        public const string PlayersFile = "PlayerModels.csv";
        public const string CharactersFile = "CharacterModels.csv";
        public const string CampaignsFile = "CampaignModels.csv";
        public const string EventsFile = "EventModels.csv";
        public const string RPGSystemsFile = "RPGSystemModels.csv";

        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.TextFile)
            {
                TextConnector text = new TextConnector();
                Connection = text;

            }
        }
    }
}
