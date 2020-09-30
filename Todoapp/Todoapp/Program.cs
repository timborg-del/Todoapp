using System;
using Todoapp.Model;

namespace Todoapp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Constructor
            Person aPerson = new Person(1535654, "David", "Göransson");
            aPerson.LastName = "Gustavsson";
            aPerson.FirstName = "Lukas";

        }
    }
}

