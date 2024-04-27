using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

// Capture information about each guest (assumption is at least one guest and unknown maximum)
// Info to capture: Fist name, last name, message to the host
// Once done, loop through each guest and print their info

namespace ConsoleUI
{
    class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>(); // or List<GuestModel> guest2 = new(); // C# 9.0
        // List<GuestModel> guests will live on entire Program lifecycle (taking up memory space)
        static void Main(string[] args)
        {
            

            GetGuestInformation(); //If guests is used as param in method (inside Main), it will not be available outside of method Ex:
            /*
             private static List<GuestModel> guests = new List<GuestModel>();
             GetGuestInformation(guests);
             */
            PrintGuestsInformation();

            Console.ReadLine();
        }


        private static void GetGuestInformation()
        {
            string moreGuestsComing = "";
            do
            {
                GuestModel guest = new GuestModel();
                /*
                Console.Write("What is your first name: ");
                guest.FirstName = Console.ReadLine();

                Console.Write("What is your last name: ");
                guest.LastName = Console.ReadLine();

                Console.Write("What is your message to the host: ");
                guest.MessageToHost = Console.ReadLine();

                Console.Write("Are more guests coming? (yes/no): ");
                moreGuestsComing = Console.ReadLine();
                */
                guest.FirstName = GetInfoFromConsole("What is your first name: ");
                guest.LastName = GetInfoFromConsole("What is your last name: ");
                guest.MessageToHost = GetInfoFromConsole("What is your message to the host: ");
                moreGuestsComing = GetInfoFromConsole("Are more guests coming? (yes/no): ");

                guests.Add(guest);
                Console.Clear();
            } while (moreGuestsComing.ToLower() == "yes");
        }

        private static string GetInfoFromConsole(string message)
        {
            string output = "";
            Console.Write(message);
            output = Console.ReadLine();
            return output;
            // or directly: return Console.ReadLine();

        }

        private static void PrintGuestsInformation()
        {
            foreach (GuestModel guest in guests) // or foreach (var guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }

        }

    }
}
