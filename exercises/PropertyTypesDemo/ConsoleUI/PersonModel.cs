using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    //TIP: In CLasses, use auto properties ({get; set;}) by default. Move it to full property when needed. 
    public class PersonModel
    {
        public string FirstName { private get; set; }
        public string LastName { get; private set; }

        public PersonModel() // No params constructor, methode overloading
        {

        }
        public PersonModel(string lastName) //Constructor of PersonModel Class (ctor)
        {
            LastName = lastName; //Constructor assure a minimum amount of data to be added to a new instance. Ex: new PersonModel("Faria") //lastName param; 

        }

        public string FullName //Very Helpful way. To put other properties together in only one property.
        {
            get { return $"{FirstName} {LastName}"; } //Making it Read Only. No Setter.
        }

        //public int Age { get; set; }

        private int _age;

        public int Age
        {
            get
            { 
                return _age; 
            }
            set
            {
                if (value >= 0 && value <= 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Age needs to be in a valid range.");
                }
                
            }
        }

        private string _password;

        public string Password
        {
            set { _password = value; } //Making it Write Only. No Getter.
        }



        //public string CPF { get; set; } // 000.000.000-00
        private string _cpf;

        public string CPF
        {
            get
            {
                string output = "***.***.**";
                output += _cpf.Substring(_cpf.Length - 5);
                return output; 
            }
            set { _cpf = value; }
        }

    }
}
