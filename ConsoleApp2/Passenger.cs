using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Passenger
    {
        private string name;
        private string phone_number;
        public string getPassengername()
        {
            return name;
        }
        public string getPassengerPhoneNumber()
        {
            return phone_number;
        }
        public void setPassengerInfo(string name, string phone)
        {
            this.name = name;
            this.phone_number = phone;
        }
    }
}
