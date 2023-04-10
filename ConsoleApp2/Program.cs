using System;
using System.Collections.Specialized;
using System.Diagnostics.Metrics;
using System.Threading.Channels;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public static class Extensions
    {
        public static int findIndex<T>(this T[] array, T item)
        {
            return Array.IndexOf(array, item);
        }
    }
    
   
   
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int choice;
            Admin admin = new Admin();
            do
            {
                Console.WriteLine("          -----------------------------------------------------------------\n");
                Console.Write("                    ");
                Console.WriteLine("welcome to myride\n");
                Console.WriteLine("          -----------------------------------------------------------------\n");
                do
                {
                    Console.WriteLine("1.book a ride\n");
                    Console.WriteLine("2.enter as driver\n");
                    Console.WriteLine("3.enter as Admin\n");
                    Console.WriteLine("-1.to quit\n");
                    choice = Convert.ToInt32(Console.ReadLine());
                } while (choice != -1 && (choice < 1 || choice > 3));
                if (choice == 1)
                {
                    Ride ride = new Ride();
                    ride.bookRide();
                    ride.giverating();
                }
                if (choice == 2)
                {
                    Driver driver = new Driver();
                    driver.SearchDriver();
                }
                if (choice == 3)
                {
                    int Adminchoice;
                    do
                    {
                        Console.WriteLine("1.add a driver\n");
                        Console.WriteLine("2.remove a driver\n");
                        Console.WriteLine("3.update  driver\n");
                        Console.WriteLine("4.search driver\n");
                        Console.WriteLine("1.exit as Admin\n");
                        Adminchoice = Convert.ToInt32(Console.ReadLine());
                        if (Adminchoice == 1)
                        {
                            Admin.AddDriver();
                        }
                        else if (Adminchoice == 2)
                        {
                            Admin.removeDriver();
                        }
                        else if (Adminchoice == 3)
                        {
                            Admin.UpdateDriverInfo();
                        }
                        else if (Adminchoice == 4)
                        {
                            Admin.searchDriver();
                        }
                    } while (Adminchoice != 5 || (Adminchoice < 1 || Adminchoice > 5));
                }
            } while (choice != -1);
        }
    }
}