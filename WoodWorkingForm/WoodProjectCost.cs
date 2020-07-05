using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace WoodWorkingForm 
{
    [Serializable()]
    public class WoodProjectCost : ISerializable
    {
        private int materialCost;
        private int labourCost;
        private int finishCost;
        private int deliveryCost;

        public WoodProjectCost()
        {

        }


        public WoodProjectCost(int materialCost, int labourCost, int finishCost, int deliveryCost)
        {
            this.materialCost = materialCost;
            this.labourCost = labourCost;
            this.finishCost = finishCost;
            this.deliveryCost = deliveryCost;
        }

        public int MaterialCost
        {
            get
            {
                return materialCost;
            }
            set
            {
                this.materialCost = value;
            }
        }

        public int LabourCost
        {
            get
            {
                return labourCost;
            }
            set
            {
                this.labourCost = value;
            }
        }

        public int FinishCost
        {
            get
            {
                return finishCost;
            }
            set
            {
                this.finishCost = value;
            }
        }

        public int DeliveryCost
        {
            get
            {
                return deliveryCost;
            }
            set
            {
                this.deliveryCost = value;
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("MaterialCost", MaterialCost);
            info.AddValue("LabourCost", LabourCost);
            info.AddValue("FinishCost", FinishCost);
            info.AddValue("DeliveryCost", DeliveryCost);
        }

        public WoodProjectCost(SerializationInfo info, StreamingContext context)
        {
            MaterialCost = (int)info.GetValue("MaterialCost", typeof(int));
            LabourCost = (int)info.GetValue("LabourCost", typeof(int));
            FinishCost = (int)info.GetValue("FinishCost", typeof(int));
            DeliveryCost = (int)info.GetValue("DeliveryCost", typeof(int));
        }


        public override string ToString()
        {
            return MaterialCost.ToString();
                  

        }
    }
}
