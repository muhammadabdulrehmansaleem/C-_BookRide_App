using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Driver
    {
            private static int count = 0;
            private int id;
            private string name;
            private int age;
            private string address;
            private string phone_no;
            private location location;
            private vehicle vehicle;
            private string gender;
            private List<double> rating = new List<double>();
            private bool availability = true;
            public Driver()
            {
                Driver.count++;
                this.id = count;
                location = new location();
                vehicle = new vehicle();
            }
            public void setid(int id)
            {
                this.id = id;
            }
            public void SearchDriver()
            {
                Admin a = new Admin();
                a.SearchForDriver();
            }
            public void updateAvailability()
            {
                if (this.availability == false)
                    this.availability = true;
                else
                    this.availability = false;
            }
            public double getRating()
            {
                double rate = 0;
                foreach (int i in rating)
                {
                    rate = rate + rating[i];
                }

                return rate / rating.Count();
            }
            public void setRating(double rating)
            {
                this.rating.Add(rating);
            }
            public void updateLocation()
            {
                string loc;
                Console.WriteLine("Enter your location: ");
                loc = Console.ReadLine();
                location.setLocation(loc);
            }
            public void setDriverInfo(string name, string address, int age, string phone, vehicle vehicle, string gender, double rating)
            {
                this.vehicle.setVehicleInfo(vehicle.type, vehicle.model, vehicle.lisence_palte);
                this.name = name;
                this.age = age;
                this.address = address;
                this.phone_no = phone;
                this.gender = gender;
                this.rating.Add(rating);
            }
            public string getNameofDriver()
            {
                return this.name;
            }
            public int getAgeofDriver()
            {
                return this.age;
            }
            public string getAddressofDriver()
            {
                return address;
            }
            public string getPhoneNumberofDriver()
            {
                return phone_no;
            }
            public vehicle GetVehicle()
            {
                return vehicle;
            }
            public location GetLocation()
            {
                return location;
            }
            public string getGenderOfDriver()
            {
                return gender;
            }
            public bool getDriverAvailability()
            {
                return availability;
            }
            public int getDriverId()
            {
                return this.id;
            }
            public void setDriverInfo2(string name, string address, int age, string phone, vehicle veh, string gender)
            {
                if (name != "")
                {
                    this.name = name;
                }
                if (address != "")
                {
                    this.address = address;
                }
                if (age != -0)
                {
                    this.age = age;
                }
                if (phone != "")
                {
                    this.phone_no = phone;
                }
                if (gender != "")
                {
                    this.gender = gender;
                }
                if (veh.type != "")
                {
                    this.vehicle.type = veh.type;
                }
                if (veh.model != "")
                {
                    this.vehicle.model = veh.model;
                }
                if (veh.lisence_palte != "")
                {
                    this.vehicle.lisence_palte = veh.lisence_palte;
                }

            }
            //name, address, age, phone, veh, gender, -90
    }
}
