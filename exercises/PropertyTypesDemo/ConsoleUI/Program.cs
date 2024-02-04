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
            PersonModel person = new PersonModel("Faria");
            person.FirstName = "Edu";
            //person.LastName = "Faria";
            person.Age = 33;
            person.CPF = "123.456.789-12";

            Console.WriteLine(person.FullName);
            Console.WriteLine(person.CPF);


            Console.ReadLine();
        }
    }
}
