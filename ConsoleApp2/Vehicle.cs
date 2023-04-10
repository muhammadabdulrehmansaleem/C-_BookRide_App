using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class vehicle
    {
        public string type;
        public string model;
        public string lisence_palte;
        public vehicle(string type = "", string model = "", string lisence_palmte = "")
        {
            this.type = type;
            this.model = model;
            this.lisence_palte = lisence_palmte;
        }
        public vehicle getVehicleInformation()
        {
            vehicle veh = new vehicle(this.type, this.model, this.lisence_palte);
            return veh;
        }
        public void setVehicleInfo(string type, string model, string lisence)
        {
            this.type = type;
            this.model = model;
            this.lisence_palte = lisence;
        }
        public string GetType()
        {
            return this.type;
        }
        public string GetModel()
        {
            return this.model;
        }
        public string GetLisence()
        {
            return this.lisence_palte;
        }

    }
}
