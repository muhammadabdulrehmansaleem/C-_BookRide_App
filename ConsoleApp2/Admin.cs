using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Admin
    {
            public static List<Driver> drivers = new List<Driver>();
            public Admin()
            {

            }
            public static Driver AssignDriver(location pickUpLocation)
            {
                double[] distance = new double[drivers.Count()];
                //List<double> distance = new List<double>();
                int k = 0;
                for (int i = 0; i < drivers.Count(); i++)
                {
                    if (drivers[i].getDriverAvailability() == true)
                    {
                        double dist;
                        location destination = drivers[i].GetLocation();
                        double x = Math.Pow(destination.getLongitude() - pickUpLocation.getLongitude(), 2);
                        double y = Math.Pow(destination.getlatitude() - pickUpLocation.getlatitude(), 2);
                        dist = Math.Sqrt(x + y);
                        //distance.Add(dist);
                        distance[k] = dist;
                        k++;
                    }
                }
                double minDistance = distance.Min();
                int index = distance.findIndex(minDistance);
                if (index != -1)
                {
                    return drivers[index];
                }
                else
                    Console.WriteLine("Driver Not found\n");
                return null;
            }
            public static void AddDriver()
            {
                Driver driver = new Driver();
                Console.WriteLine("Enter the name of the driver: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the age of the driver: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the gender of the driver: ");
                string gender = Console.ReadLine();
                Console.WriteLine("Enter the address of the driver: ");
                string address = Console.ReadLine();
                Console.WriteLine("Enter the phone number of the driver: ");
                string phone = Console.ReadLine();
                //Console.WriteLine("Enter the Current Location of the driver: ");
                //string cuuloc=Console.ReadLine();
                Console.WriteLine("Enter the Vehicle type of the driver: ");
                string vehtype = Console.ReadLine();
                Console.WriteLine("Enter the Vehicle model of the driver: ");
                string model = Console.ReadLine();
                Console.WriteLine("Enter the Vehicle lisense plate of the driver: ");
                string lsiense = Console.ReadLine();
                //Console.WriteLine("Enter availability status: ");
                //string status=(Console.ReadLine());
                vehicle veh = new vehicle();
                veh.type = vehtype;
                veh.model = model;
                veh.lisence_palte = lsiense;
                driver.setDriverInfo(name, address, age, phone, veh, gender, 0);
                //driver.updateAvailability();
                drivers.Add(driver);
                for (int i = 0; i < drivers.Count; i++)
                {
                    Console.WriteLine("The id is: ");
                    Console.WriteLine(drivers[i].getDriverId());
                    Console.WriteLine("\n");
                }
            }
            public static void UpdateDriverInfo()
            {
                Console.WriteLine("Enter id of the driver: ");
                int id = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < drivers.Count; i++)
                {
                    if (drivers[i].getDriverId() == id)
                    {
                        Console.WriteLine("----------Driver with id ");
                        Console.WriteLine(id);
                        Console.WriteLine("exist----------");
                        Console.WriteLine("Enter the name of the driver: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the age of the driver: ");
                        int age = -0;
                        string ages = Console.ReadLine();
                        if (ages != "")
                        {
                            age = Convert.ToInt32(ages);
                        }
                        Console.WriteLine("Enter the gender of the driver: ");
                        string gender = Console.ReadLine();
                        Console.WriteLine("Enter the address of the driver: ");
                        string address = Console.ReadLine();
                        Console.WriteLine("Enter the Vehicle type of the driver: ");
                        string vehtype = Console.ReadLine();
                        Console.WriteLine("Enter the Vehicle model of the driver: ");
                        string model = Console.ReadLine();
                        Console.WriteLine("Enter the Vehicle lisense plate number of the driver: ");
                        string lsiense = Console.ReadLine();
                        Console.WriteLine("Enter Phone number of the driver: ");
                        string phone = Console.ReadLine();
                        vehicle veh = new vehicle();
                        veh.type = vehtype;
                        veh.model = model;
                        veh.lisence_palte = lsiense;
                        drivers[i].setDriverInfo2(name, address, age, phone, veh, gender);
                    }
                }
            }
            public static void removeDriver()
            {
                Console.WriteLine("Enter id of the driver you want to remove: ");
                int id = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < drivers.Count(); i++)
                {
                    if (drivers[i].getDriverId() == id)
                    {
                        drivers.Remove(drivers[i]);
                    }
                }
            }
            public static void searchDriver()
            {
                string id;
                Console.WriteLine("Enter the id of the driver: ");
                id = Console.ReadLine();
                Console.WriteLine("Enter the name of the driver: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the age of the driver: ");
                //int age = -0;
                string age = Console.ReadLine();
                //if (ages != "")
                //{
                //    age = Convert.ToInt32(ages);
                //}
                Console.WriteLine("Enter the gender of the driver: ");
                string gender = Console.ReadLine();
                Console.WriteLine("Enter the address of the driver: ");
                string address = Console.ReadLine();
                Console.WriteLine("Enter the Vehicle type of the driver: ");
                string vehtype = Console.ReadLine();
                Console.WriteLine("Enter the Vehicle model of the driver: ");
                string model = Console.ReadLine();
                Console.WriteLine("Enter the Vehicle lisense plate number of the driver: ");
                string lsiense = Console.ReadLine();
                bool status = false;
                int index = 0;
                List<Driver> drive2 = new List<Driver>();
                if (name != "")
                {
                    for (int i = 0; i < drivers.Count(); i++)
                    {
                        if (drivers[i].getNameofDriver() == name)
                        {
                            drive2.Add(drivers[i]);
                        }
                    }
                }
                if (age != "")
                {
                    if (drive2.Count() == 0)
                    {
                        for (int i = 0; i < drivers.Count(); i++)
                        {
                            if (drivers[i].getAgeofDriver() == Convert.ToInt32(age))
                            {
                                drive2.Add(drivers[i]);
                            }
                        }
                    }
                    if (drive2.Count() != 0)
                    {
                        for (int i = 0; i < drive2.Count(); i++)
                        {
                            if (drive2[i].getAgeofDriver() != Convert.ToInt32(age))
                            {
                                drive2.Remove(drive2[i]);
                            }
                        }
                    }
                }
                if (address != "")
                {
                    if (drive2.Count() == 0)
                    {
                        for (int i = 0; i < drivers.Count(); i++)
                        {
                            if (drivers[i].getAddressofDriver() == address)
                            {
                                drive2.Add(drivers[i]);
                            }
                        }
                    }
                    if (drive2.Count() != 0)
                    {
                        for (int i = 0; i < drive2.Count(); i++)
                        {
                            if (drive2[i].getAddressofDriver() != address)
                            {
                                drive2.Remove(drive2[i]);
                            }
                        }
                    }
                }
                if (id != "")
                {
                    if (drive2.Count() == 0)
                    {
                        for (int i = 0; i < drivers.Count(); i++)
                        {
                            if (drivers[i].getDriverId() == Convert.ToInt32(id))
                            {
                                drive2.Add(drivers[i]);
                            }
                        }
                    }
                    if (drive2.Count() != 0)
                    {
                        for (int i = 0; i < drive2.Count(); i++)
                        {
                            if (drive2[i].getDriverId() != Convert.ToInt32(id))
                            {
                                drive2.Remove(drive2[i]);
                            }
                        }
                    }
                }
                if (gender != "")
                {
                    if (drive2.Count() == 0)
                    {
                        for (int i = 0; i < drivers.Count(); i++)
                        {
                            if (drivers[i].getGenderOfDriver() == gender)
                            {
                                drive2.Add(drivers[i]);
                            }
                        }
                    }
                    if (drive2.Count() != 0)
                    {
                        for (int i = 0; i < drive2.Count(); i++)
                        {
                            if (drive2[i].getGenderOfDriver() != gender)
                            {
                                drive2.Remove(drive2[i]);
                            }
                        }
                    }
                }
                if (vehtype != "")
                {
                    if (drive2.Count() == 0)
                    {
                        for (int i = 0; i < drivers.Count(); i++)
                        {
                            if (drivers[i].GetVehicle().GetType() == vehtype)
                            {
                                drive2.Add(drivers[i]);
                            }
                        }
                    }
                    if (drive2.Count() != 0)
                    {
                        for (int i = 0; i < drive2.Count(); i++)
                        {
                            if (drive2[i].GetVehicle().GetType() != vehtype)
                            {
                                drive2.Remove(drive2[i]);
                            }
                        }
                    }
                }
                if (model != "")
                {
                    if (drive2.Count() == 0)
                    {
                        for (int i = 0; i < drivers.Count(); i++)
                        {
                            if (drivers[i].GetVehicle().GetModel() == model)
                            {
                                drive2.Add(drivers[i]);
                            }
                        }
                    }
                    if (drive2.Count() != 0)
                    {
                        for (int i = 0; i < drive2.Count(); i++)
                        {
                            if (drive2[i].GetVehicle().GetModel() != model)
                            {
                                drive2.Remove(drive2[i]);
                            }
                        }
                    }
                }
                if (lsiense != "")
                {
                    if (drive2.Count() == 0)
                    {
                        for (int i = 0; i < drivers.Count(); i++)
                        {
                            if (drivers[i].GetVehicle().GetLisence() == lsiense)
                            {
                                drive2.Add(drivers[i]);
                            }
                        }
                    }
                    if (drive2.Count() != 0)
                    {
                        for (int i = 0; i < drive2.Count(); i++)
                        {
                            if (drive2[i].GetVehicle().GetLisence() != lsiense)
                            {
                                drive2.Remove(drive2[i]);
                            }
                        }
                    }
                }
                if (drive2.Count() != 0)
                {
                    for (int i = 0; i < drive2.Count(); i++)
                    {
                        Console.WriteLine("-----------------------------------------------------------");
                        Console.Write("Name     ");
                        Console.Write("Age     ");
                        Console.Write("Gender     ");
                        Console.Write("Veh.type     ");
                        Console.Write("Model     ");
                        Console.Write("V.Lisence     ");
                        Console.Write("\n");
                        Console.Write(drive2[i].getNameofDriver());
                        Console.Write("      ");
                        Console.Write(Convert.ToString(drive2[i].getAgeofDriver()), "     ");
                        Console.Write("      ");
                        Console.Write(drive2[i].getGenderOfDriver(), "     ");
                        Console.Write("      ");
                        Console.Write(drive2[i].GetVehicle().GetType(), "     ");
                        Console.Write("      ");
                        Console.Write(drive2[i].GetVehicle().GetModel(), "     ");
                        Console.Write("      ");
                        Console.Write(drive2[i].GetVehicle().GetLisence(), "     ");
                        Console.Write("\n");
                    }

                }
            }
            public void SearchForDriver()
            {
                int id;
                Console.WriteLine("Enter the id of the driver: ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name of the driver: ");
                string name = Console.ReadLine();
                bool status = false;
                int index = 0;
                for (int i = 0; i < drivers.Count(); i++)
                {
                    if (drivers[i].getDriverId() == id)
                    {
                        status = true;
                        index = i;
                        break;
                    }
                    else
                        status = false;
                }
                if (status == true)
                {
                    Console.WriteLine("Hello ");
                    Console.WriteLine(drivers[index].getNameofDriver());
                    Console.WriteLine("\n");
                    Console.WriteLine("1.For updating your availability status\n");
                    Console.WriteLine("2.For updating your Location status\n");
                    Console.WriteLine("3.To Quit As Driver\n");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        drivers[index].updateAvailability();
                    }
                    if (choice == 2)
                    {
                        drivers[index].updateLocation();
                    }
                    if (choice == 3)
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
     }
}
