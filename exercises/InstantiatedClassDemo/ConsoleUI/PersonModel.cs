using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    //Instantiated Class = Blueprint
    //Do not use "static"
    public class PersonModel //Class dedicated to store data, name it ...Model
    {

        //Those are fields
        public string FirstName { get; set; } //type "prop" for intellisense
        public string LastName { get; set; } //PascalCase
        public string EmailAddress { get; set; }
        public bool HasBeenGreeted { get; set; }


        //Those are properties
        /* Part of IMPORTANT in Program.cs
        public string firstName; // Attributes NEED to be public to use as model
        public string lastName; // camelCase
        public string emailAddress;
        */

        //camel vs pascal case stands to do not conflict with a private variable with the same name of a get/set attribute, ex: firstName vs FirstName

    }
}
