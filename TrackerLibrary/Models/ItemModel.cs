using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class ItemModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public ItemModel()
        {

        }

        public ItemModel(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public string DisplayedItemName
        {
            get
            {
                return $"{ Name } - { Quantity }";
            }
        }
    }
}
