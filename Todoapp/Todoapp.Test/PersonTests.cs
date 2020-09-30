using System;
using Xunit;
using Todoapp.Model;
using System.Drawing;

namespace Todoapp.Test
{
    public class PersonTests
    {
        [Fact]
        public void NameNotNull()
        {
            int personId = 0;
            string firstName = "";
            string lastName = " ";

            //onely do Act&Assert when throw a Exception
            Assert.Throws<ArgumentException>(() => new Person(personId, firstName, lastName));

        }
        [Theory]
        [InlineData(null, "Goodname")]
        [InlineData("", "GoodName")]
        [InlineData(" ", "Goodname")]

        [InlineData("Goodname ", null)]
        [InlineData("Goodname", "")]
        [InlineData("Goodname", " ")]

        public void BadConstructerName(string firstName, string lastName) // Whe are not testing personID
        {
            int personId = 0;

            Assert.Throws<ArgumentException>(() => new Person(personId, firstName, lastName));

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void BadFirstNameProperty(string firstName)
        {
            Person aPerson = new Person(20, "Calle", "Carlsson");

            Assert.Throws<ArgumentException>(() => aPerson.FirstName = firstName);

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void BadLastNameProperty(string lastName)
        {
            Person aPerson = new Person(20, "Calle", "Carlsson");

            Assert.Throws<ArgumentException>(() => aPerson.LastName = lastName);
        }
    }
}


    

