using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class RPGSystemModel
    {
        public string SystemName { get; set; }

        List<SessionModel> ActiVeSessionsInSystem { get; set; }
    }
}
