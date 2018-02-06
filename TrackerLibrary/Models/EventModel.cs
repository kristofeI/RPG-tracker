using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class EventModel
    {
        public int Id { get; set; }

        public DateTime EventTime { get; set; }

        public string EventDescription { get; set; }

        public string DisplayedEvent
        {
            get
            {
                return $"{ EventTime } - { EventDescription }";
            }
        }

        public EventModel()
        {

        }

        public EventModel(DateTime time, string description)
        {
            EventTime = time;
            EventDescription = description;
        }
    }
}
