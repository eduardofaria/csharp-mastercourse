using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class UserMessages
    {
        public static void ApplicationStartMessage(string firstName)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Static Class Demo App");
            int hourDay = DateTime.Now.Hour;

            if (hourDay > 4 && hourDay < 12)
            {
                Console.WriteLine($"Good Morning { firstName }!");
            } else if (hourDay >= 12 && hourDay < 18)
            {
                Console.WriteLine($"Good Afternoon { firstName }!");
            } else
            {
                Console.WriteLine($"Good Night { firstName }!");
            }

        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("Thank you for using the Static Class Demo App.");
        }
        
    }
}
