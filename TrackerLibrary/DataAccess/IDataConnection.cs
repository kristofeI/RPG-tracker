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


        WeaponModel AddNewWeapon(WeaponModel model);

        SkillModel AddNewSkill(SkillModel model);

        ItemModel AddNewItem(ItemModel model);

        EventModel AddNewEvent(EventModel model);

        PlayerModel AddNewPlayer(PlayerModel model);

        CharacterModel AddNewCharacter(CharacterModel model);

        CampaignModel AddNewCampaign(CampaignModel model);



        EventModel UpdateEvent(EventModel model);

        PlayerModel UpdatePlayer(PlayerModel model);

        CharacterModel UpdateCharacter(CharacterModel model);

        CampaignModel UpdateCampaign(CampaignModel model);





        void AddCharacterToPlayer(CharacterModel character, PlayerModel player);

        void AddWeaponToCharacter(WeaponModel weapon, CharacterModel character);

        void AddSkillToCharacter(SkillModel skill, CharacterModel character);

        void AddItemToCharacter(ItemModel item, CharacterModel character);



        List<SkillModel> GetAllSkillsOfOneCharacter(CharacterModel character);

        List<PlayerModel> GetAllPlayers();

        List<CharacterModel> GetAllCharactersOfOnePlayer(PlayerModel character);

        bool IsPlayerNameUnique(string playerName);
    }
}
