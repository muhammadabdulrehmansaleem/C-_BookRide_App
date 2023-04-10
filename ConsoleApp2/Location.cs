using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class location
    {
            private double longitude;
            private double latitude;
            public location(double longitude = 0, double latitude = 0)
            {
                this.longitude = longitude;
                this.latitude = latitude;
            }
            public location getLocation()
            {
                location loc = new location(this.longitude, this.latitude);
                return loc;
            }
            public void setLocation(string location)
            {
                double lati, longi;
                string[] words = location.Split(',');
                lati = Convert.ToDouble(words[0]);
                longi = Convert.ToDouble(words[1]);
                this.longitude = longi;
                this.latitude = lati;
            }
            public double getLongitude()
            {
                return this.longitude;
            }
            public double getlatitude()
            {
                return this.latitude;
            }
        }
}
