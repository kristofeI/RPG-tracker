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

        PlayerModel AddNewPlayer(PlayerModel model);

        CharacterModel AddNewCharacter(CharacterModel model);

        SessionModel AddNewSession(SessionModel model);





        List<SkillModel> GetAllSkillsOfOneCharacter(CharacterModel character);

        List<PlayerModel> GetAllPlayers();

    }
}
