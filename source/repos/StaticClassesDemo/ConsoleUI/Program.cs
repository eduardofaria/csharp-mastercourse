using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fisrtName = RequestData.GetString("Whats is your first name? ");
            UserMessages.ApplicationStartMessage(fisrtName);

            double x = RequestData.GetDouble("Please enter a number: ");
            double y = RequestData.GetDouble("Please enter another number: ");
            double result = CalculateData.AddDoubles(x, y);

            UserMessages.PrintMessage($"The sum of {x} and {y} is: {result}");

            Console.ReadLine();
        }

    }
}