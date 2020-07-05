using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace WoodWorkingForm
{
    [Serializable()]
    public class WoodProject : ISerializable
    {
        //Fields, Attributes or properties 
        private string name;
        private string description;
        private int projectNumber;
        private WoodProjectCost woodProjectCost;
        private string comments;

        public WoodProject()
        {

        }

        public WoodProject(string name, string description, int projectNumber)
        {
            this.name = name;
            this.description = description;
            this.projectNumber = projectNumber;
        }

        public WoodProject(string name, string description, int projectNumber, WoodProjectCost woodProjectCost)
        {
            this.name = name;
            this.description = description;
            this.projectNumber = projectNumber;
            this.woodProjectCost = woodProjectCost;
        }

        public WoodProject(string name, string description, int projectNumber, WoodProjectCost woodProjectCost, string comments)
        {
            this.name = name;
            this.description = description;
            this.projectNumber = projectNumber;
            this.woodProjectCost = woodProjectCost;
            this.comments = comments;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                this.description = value;
            }
        }
        
        public int ProjectNumber
        {
            get
            {
                return projectNumber;
            }
            set
            {
                this.projectNumber = value;
            }
        }
        
        public WoodProjectCost WoodProjectCost
        {
            get
            {
                return woodProjectCost;
            }
            set
            {
                this.woodProjectCost = value;
            }
        }

        public string Comments
        {
            get
            {
                return comments;
            }
            set
            {
                this.comments = value;
            }
        }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name",Name);
            info.AddValue("Description", Description);
            info.AddValue("ProjectNumber", ProjectNumber);
            info.AddValue("WoodProjectCost", WoodProjectCost);
            info.AddValue("Comments", Comments);
        }

        public WoodProject(SerializationInfo info, StreamingContext context)
        {
            name = (string)info.GetValue("Name", typeof(string));
            description = (string)info.GetValue("Description", typeof(string));
            projectNumber = (int)info.GetValue("ProjectNumber", typeof(int));
            woodProjectCost = (WoodProjectCost)info.GetValue("WoodProjectCost", typeof(WoodProjectCost));
            comments = (string)info.GetValue("Comments", typeof(string));
        }

        public override string ToString()
        {
            return name
                +  description
                +  projectNumber
                +  woodProjectCost
                +  comments
                ;
        }
    }
}
