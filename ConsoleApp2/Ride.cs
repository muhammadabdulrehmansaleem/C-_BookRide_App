using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Ride
    {
            private location startLocation;
            private location endLocation;
            private double price;
            private Driver driver;
            private Passenger Passenger;
            public Ride()
            {
                startLocation = new location();
                endLocation = new location();
                driver = new Driver();
                Passenger = new Passenger();
            }
            public Ride(string startloc, string endloc, int price, Driver driver, Passenger Passenger)
            {
                startLocation.setLocation(startloc);
                endLocation.setLocation(endloc);
                price = price;
                driver.setDriverInfo(driver.getNameofDriver(), driver.getAddressofDriver(), driver.getAgeofDriver(), driver.getPhoneNumberofDriver(), driver.GetVehicle(), driver.getGenderOfDriver(), driver.getRating());
                Passenger.setPassengerInfo(Passenger.getPassengername(), Passenger.getPassengerPhoneNumber());
            }
            public void assignPassenger()
            {
                string name;
                Console.WriteLine("Enter name of the Passenger: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter phone number of the Passenger: ");
                string phone = Console.ReadLine();
                Passenger.setPassengerInfo(name, phone);
            }
            public void getLocations()
            {
                string start;
                Console.WriteLine("Enter starting location: ");
                start = Console.ReadLine();
                Console.WriteLine("Enter Ending location: ");
                string end = Console.ReadLine();
                startLocation.setLocation(start);
                endLocation.setLocation(end);
            }
            public void assignDriver()
            {
                //Admin a = new Admin();
                //driver=a.AssignDriver(startLocation);
                this.driver = Admin.AssignDriver(this.startLocation);

            }
            public void calculatePrice()
            {
                double distance;
                double x = Math.Pow(endLocation.getLongitude() - startLocation.getLongitude(), 2);
                double y = Math.Pow(endLocation.getlatitude() - startLocation.getlatitude(), 2);
                distance = Math.Sqrt(x + y);
                string vehtype = driver.GetVehicle().GetType();
                if (vehtype == "car")
                {
                    price = ((distance * 272) / 15) + ((distance * 272) * 20) / 100;
                }
                else if (vehtype == "Bike")
                {
                    price = ((distance * 272) / 50) + ((distance * 272) * 5) / 100;
                }
                else
                {
                    price = ((distance * 272) / 35) + ((distance * 272) * 10) / 100;
                }
            }
            public void bookRide()
            {
                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your phone Number: ");
                string phone_number = Console.ReadLine();
                this.Passenger.setPassengerInfo(name, phone_number);
                string start, end;
                Console.WriteLine("Enter your Starting Location: ");
                start = Console.ReadLine();
                location pickUpLocation = new location();
                pickUpLocation.setLocation(start);
                Console.WriteLine("Enter your Destination: ");
                end = Console.ReadLine();
                location destination = new location();
                destination.setLocation(end);
                Console.WriteLine("Enter the vehicle type: ");
                Console.WriteLine("1:Bike\n");
                Console.WriteLine("2:Car\n");
                Console.WriteLine("3:Rickshaw\n");
                string vehtype = Console.ReadLine();
                //Console.WriteLine("")
                double distance;
                double x = Math.Pow(destination.getLongitude() - pickUpLocation.getLongitude(), 2);
                double y = Math.Pow(destination.getlatitude() - pickUpLocation.getlatitude(), 2);
                distance = Math.Sqrt(x + y);
                double price;
                if (vehtype == "car")
                {
                    price = ((distance * 272) / 15) + ((distance * 272) * 20) / 100;
                }
                else if (vehtype == "Bike")
                {
                    price = ((distance * 272) / 50) + ((distance * 272) * 5) / 100;
                }
                else
                {
                    price = ((distance * 272) / 35) + ((distance * 272) * 10) / 100;
                }
                Console.WriteLine("Price for this ride is: ");
                Console.WriteLine(Math.Ceiling(price));
                Console.WriteLine("Enter ‘Y’ if you want to Book the ride, enter ‘N’ if you want to cancel operation: ");
                char choice = Convert.ToChar(Console.ReadLine());
                if (choice == 'Y' || choice == 'y')
                {
                    Console.WriteLine("Happy Travel...!\n");
                }
                //this.assignDriver();
            }
            public void giverating()
            {
                double rating;
                do
                {
                    Console.WriteLine("Give rating out of 5: ");
                    rating = Convert.ToDouble(Console.ReadLine());

                } while (rating < 0 || rating > 5);
                this.driver.setRating(rating);
            }
        }
}

