using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class RequestData
    {
        public static string GetString(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();
            return output;
        }
        public static double GetDouble(string message)
        {
            Console.Write(message);
            string numberString = Console.ReadLine();
            double output;

            bool isDouble = double.TryParse(numberString, out output);

            while (isDouble == false)
            {
                Console.WriteLine("Please enter a valid number");
                Console.Write(message);
                numberString = Console.ReadLine();

                isDouble = double.TryParse(numberString, out output);
            }
            return output;
        }
    }
}
