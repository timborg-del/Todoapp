using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Todoapp.Model;

namespace Todoapp.Data
{
    public class People
    {
        // Camelcase = oneTwoT 
        static Person[] personArray = new Person[0];

        public int Size()
        {
            return personArray.Length;
        }
        public Person[] FindAll()
        {
            return personArray;
        }

        public Person FindById(int personId)
        {
            // store person in Person in personArray
            foreach (Person person in personArray)
            {
                if (person.PersonId == personId)
                {
                    return person;
                }
            }
            return null;
        }
        //If its not a return type it must be Void 
        public void NewPerson(string firstName, string lastName)
        {
            int number = personArray.Length;
            int personId = PersonSequencer.NextPersonId();
            Person newPerson = new Person(personId, firstName, lastName);
            Array.Resize<Person>(ref personArray, number + 1);
            personArray[number] = newPerson; // put in zero first 
            /*number = 1
             * ++number     Value of number is 2 uses 2 
             * number++     Value of number is 2 uses 1
             * number+1     Value of number is 1 uses 2
             */
        }
        public void Remove(Person person)
        {

            int indexDel = Array.IndexOf(personArray, person);
            if (indexDel >= 0)
            {
                personArray[indexDel] = personArray[personArray.Length - 1];
                Array.Resize<Person>(ref personArray, personArray.Length - 1);

            }
            // 1:Gustav       // 2:Calle
            //personArray[2] = personArray[1];
            //1:gustav 2:gustav after run with array.


        }

        public void Clear()
        {
            personArray = new Person[0]; // 
        }

    }
}
