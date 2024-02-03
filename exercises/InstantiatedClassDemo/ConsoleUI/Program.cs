using ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TIP: In general, instantiated class store data. Static classes are for stateless processing

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<PersonModel> people = new List<PersonModel>(); // var people is a list of type <PersonModel>
            
            string firstName = string.Empty;

            do
            {
                Console.Write("What is your first name? Or type 'exit' to quit: ");
                firstName = Console.ReadLine();
                
                if (firstName.ToLower() != "exit")
                {
                    Console.Write("What is your last name? ");
                    string lastName = Console.ReadLine();

                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    people.Add(person); //This will not work if not instantiate a person first, as on two lines above
                    //^ this person instance do not exist outside this scope {}
                    // But person data still exist on people list that it was added.
                }
            } while (firstName.ToLower() != "exit");

            foreach (PersonModel p in people)
            {
                //Console.WriteLine($"{p.FirstName} {p.LastName}");
                ProcessPerson.GreetPerson(p);
            }

            /*
            //Problem with multi users
            string firstName;
            string lastName;
            string emailAddress;

            //Problem with sync multi users data
            List<string> firstName = new List<string>();
            List<string> lastName = new List<string>();
            */

            /*
            //Creating an object from the type PersonModel using its as blueprint
            PersonModel person = new PersonModel(); //Class PersonModel must be instantiated (type PersonModel + new) to be used as a model
            person.firstName = "Edu";
            PersonModel secondPerson = new PersonModel();
            secondPerson.firstName = "Dudu";
            Console.WriteLine(person.firstName);
            Console.WriteLine(secondPerson.firstName);
            */




            /* IMPORTANT
            //Using instantiated class to build a list of that model
            //Creating a List of a new type: PersonModel. Works just like <string>, <int>, etc
            List<PersonModel> people = new List<PersonModel>(); // must be initiated with "new" just like a single object

            PersonModel person = new PersonModel();//This variable just holds all the attributes of this type (model)
            person.firstName = "Edu";
            people.Add(person); // Adding a single person to a "List of person" (people)

            //Another instance of person
            person = new PersonModel(); //This person variable is not the same of "person.firstName = "Edu";". It is a new reference.
            person.firstName = "Dudu";
            people.Add(person);

            foreach (PersonModel p in people) // list people added to the person list. Each person is an instance of type PeronModel, added to a List of person (people)
            {
                Console.WriteLine(p.firstName);
            }
            */

            Console.ReadLine();

        }
    }
}

/*
//Common way to initialize
PersonModel person = new PersonModel();
person.firstName = "Edu";

//Simpler way to initialize
PersonModel person = new PersonModel
{
    firstName = "Edu"
}
*/

