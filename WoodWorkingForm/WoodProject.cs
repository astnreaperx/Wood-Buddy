using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Collections;

namespace WoodWorkingForm
{
    [Serializable()]
    [XmlRoot("WoodProject")]
    public class WoodProject : ISerializable
    {
        //Fields, Attributes or properties 
        
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProjectNumber { get; set; }

        [XmlArray("WoodItemCosts")]
        [XmlArrayItem("Cost")]
        public List<WoodItemCost> WoodItemCosts { get; set; }
        public string Comments { get; set; }

        public WoodProject()
        {
        }

        public WoodProject(string Name, string Description, int ProjectNumber)
        {
            this.Name = Name;
            this.Description = Description;
            this.ProjectNumber = ProjectNumber;
        }

        public WoodProject(string Name, string Description, int ProjectNumber, string Comments)
        {
            this.Name = Name;
            this.Description = Description;
            this.ProjectNumber = ProjectNumber;
            this.Comments = Comments;
        }

        public WoodProject(string Name, string Description, int ProjectNumber,List<WoodItemCost> WoodItemCosts, string Comments)
        {
            this.Name = Name;
            this.Description = Description;
            this.ProjectNumber = ProjectNumber;
            this.WoodItemCosts = WoodItemCosts;
            this.Comments = Comments;
        }

        public void AddWoodItemCost(WoodItemCost cost)
        {
            this.WoodItemCosts.Add(cost);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name",Name);
            info.AddValue("Description", Description);
            info.AddValue("ProjectNumber", ProjectNumber);
            info.AddValue("WoodItemCosts", WoodItemCosts);
            info.AddValue("Comments", Comments);
        }

        public WoodProject(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Description = (string)info.GetValue("Description", typeof(string));
            ProjectNumber = (int)info.GetValue("ProjectNumber", typeof(int));
            WoodItemCosts = (List<WoodItemCost>)info.GetValue("WoodItemCosts", typeof(List<WoodItemCost>));
            Comments = (string)info.GetValue("Comments", typeof(string));
        }

        public override string ToString()
        {
            return Name
                + Description
                + ProjectNumber
                + WoodItemCosts
                + Comments
                ;
        }
    }
}
