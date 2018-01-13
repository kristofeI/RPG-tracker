using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class BodyNeedModel
    {
        /// <summary>
        /// Represents the name of the body need.
        /// </summary>
        public string Name { get; set; }

        public float Value { get; set; }

        public float IncreasePerHour { get; set; }
    }
}
