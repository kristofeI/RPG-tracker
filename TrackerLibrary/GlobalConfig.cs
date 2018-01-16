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
        public static IDataConnection Connection { get; private set; }

        //public static int SelectedRPGSystemId { get; set; }
        //public static int SelectedActiveSessionId { get; set; }
        //public static int SelectedPlayerId { get; set; }
        //public static int SelectedCharacterId { get; set; }

        ////Make a proper id's values

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.TextFile)
            {
                //TODO - Create the Text Connection properly
                TextConnector text = new TextConnector();
                Connection = text;

            }
        }
    }
}
