using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace WoodWorkingForm
{
    [Serializable()]
    [XmlRoot("WoodItemCosts")]
    public class WoodItemCost : ISerializable
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("Description")]
        public string Description { get; set; }
        [XmlAttribute("ItemCost")]
        public int ItemCost { get; set; }

        public WoodItemCost()
        {

        }
        
        public WoodItemCost(string Name, int ItemCost)
        {
            this.Name = Name;
            this.ItemCost = ItemCost;
        }

        public WoodItemCost(string Name, string Description, int ItemCost)
        {
            this.Name = Name;
            this.Description = Description;
            this.ItemCost = ItemCost;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Description", Description);
            info.AddValue("ItemCost", ItemCost);
        }

        public WoodItemCost(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Description = (string)info.GetValue("Description", typeof(string));
            ItemCost = (int)info.GetValue("ItemCost", typeof(int));
        }

        public override string ToString()
        {
            return Name
                + Description
                + ItemCost
                ;
        }
    }
}
