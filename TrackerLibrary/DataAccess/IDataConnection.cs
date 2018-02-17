using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {


        void AddNewWeapon(WeaponModel model);

        void AddNewSkill(SkillModel model);

        void AddNewItem(ItemModel model);

        void AddNewEvent(EventModel model);

        void AddNewPlayer(PlayerModel model);

        void AddNewCharacter(CharacterModel model);

        void AddNewCampaign(CampaignModel model);

        void AddNewRPGSystem(RPGSystemModel model);



        void UpdateEvent(EventModel model);

        void UpdatePlayer(PlayerModel model);

        void UpdateCharacter(CharacterModel model);

        void UpdateCampaign(CampaignModel model);

        void UpdateRPGSystem(RPGSystemModel model);

        



        List<SkillModel> GetAllSkillsOfOneCharacter(CharacterModel character);

        List<PlayerModel> GetAllPlayers();

        List<CharacterModel> GetAllCharactersOfOnePlayer(PlayerModel character);

        List<CampaignModel> GetAllCampaigns();

        RPGSystemModel GetRPGSystem(RPGSystemModel rpgSystem);

        List<RPGSystemModel> MakeProperListOfRpgSystems(List<RPGSystemModel> defaultRpgSystems);

        List<RPGSystemModel> GetAllRPGSystems();

        bool IsPlayerNameUnique(string playerName);
    }
}
