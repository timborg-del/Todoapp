using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Todoapp.Data;
using System.Drawing;
using Todoapp.Model;
[assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace Todoapp.Test
{
    public class PeopleTest
    {
        [Fact]
        public void PersonArrayLength()
        {
            //Arrange
            People newPeople = new People();
            newPeople.Clear();
            newPeople.NewPerson("Jörgen", "Bollen");
            int expected = 1;
            //Act 
            int actual = newPeople.Size();


            //Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void FindAll()
        {
            //Arrange
            People newPeople = new People();
            newPeople.Clear();
            newPeople.NewPerson("Jörgen", "Boll");
            newPeople.NewPerson("Olle", "Bollen");


            //act
            Person[] actual = newPeople.FindAll();

            //Assert
            Assert.Equal("Jörgen", actual[0].FirstName);
            Assert.Equal("Boll", actual[0].LastName);
            Assert.Equal("Olle", actual[1].FirstName);
            Assert.Equal("Bollen", actual[1].LastName);
        }
        [Fact]
        public void FindByIdExistingPerson()
        {
            //Arrange
            People newPeople = new People();
            newPeople.Clear();
            newPeople.NewPerson("Jörgen", "Boll");

            //act
            Person expected = newPeople.FindAll()[0];
            Person actual = newPeople.FindById(expected.PersonId);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact] // FindByIdNonExistingPerson
        public void FindByIdNonExistingPerson()
        {
            //Arrange
            People newPeople = new People();
            newPeople.Clear();
            newPeople.NewPerson("Jurgen", "Banan");
            


            // Act

            Person actual = newPeople.FindById(2); ;
            Person expected = null;

            //Assert
            Assert.Equal(expected, actual);

        }
        [Fact]  // ResizePersonArray
        public void TestNewPersonArray()
        {
            //Arrange
            People newPeople = new People();
            newPeople.Clear();
            newPeople.NewPerson("Jörgen", "Bollen");
            int expectedSize = 1;
            //Act 
            int actualSize = newPeople.Size();
            Person actualPerson = newPeople.FindAll()[0];
            //Assert
            Assert.Equal(expectedSize, actualSize);
            Assert.Equal("Jörgen", actualPerson.FirstName);
            Assert.Equal("Bollen", actualPerson.LastName);

        }
        [Fact]
        public void RemovePerson()
        {
            //Arrange
            People people = new People();
            people.Clear();
            people.NewPerson("Göran", "Jsson");
            people.NewPerson("Olle", "Jsson");


            //Act
           int size = people.Size();
           Person[] persons = people.FindAll();
           
            people.Remove(persons[0]);


            //Assert
            Assert.Equal(size -1, people.Size());
            Assert.Equal("Olle", people.FindAll()[0].FirstName);

        }

    }
}
