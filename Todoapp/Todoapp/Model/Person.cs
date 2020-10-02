using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Todoapp.Model
{
   public class Person
    {
        // Names!
        readonly int personId;
        string firstName = "John";
        string lastName = "Doh";



        public int PersonId
        {
            get
            {
                return personId;
            }
        }

        public string FirstName
        {
            get
            {
                 return firstName;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value)) //True
                {
                    throw new ArgumentException("First name is not filled out make sure there is no space");
                }
                else
                {
                    firstName = value;
                }
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value)) //True //Static method for string method thats why "S"
                {
                    throw new ArgumentException("Last name is not filled out make sure there is no space");
                }
                else
                {
                    lastName = value;
                }
            }
        }


        // Constructor 
        public Person(int personId, string firstName, string lastName)
        {
            this.personId = personId;
            this.FirstName = firstName;
            this.LastName = lastName;
           
        }

    }
}








