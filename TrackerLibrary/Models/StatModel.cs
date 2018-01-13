using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class StatModel
    {
        public string Description { get; set; }

        public float Base { get; set; }

        public float Actual { get; set; }

        public float Min { get; set; }

        public float Max { get; set; }

        public float IncreasePerLevel { get; set; }
    }
}
