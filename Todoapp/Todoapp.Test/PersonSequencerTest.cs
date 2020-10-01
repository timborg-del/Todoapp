using System;
using System.Collections.Generic;
using System.Text;
using Todoapp.Data;
using Xunit;
using Xunit.Sdk;

namespace Todoapp.Test
{
    public class PersonSequencerTest
    {
        [Fact]
        public void IncresId()
        {
            //Arrange
            int number = PersonSequencer.NextPersonId();// Onely works cuz its static 
            int expected = number + 1;
            
            //Act
            int result = PersonSequencer.NextPersonId();            
           
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ResetToZero()
        {
            //arrange
            int expected = 1;
            // To be sure there tested numbers stored in personId variabal 
            for (int i = 0; i < 10; i++)
            {
                PersonSequencer.NextPersonId();
            }
            //act
            PersonSequencer.Reset();

            int result = PersonSequencer.NextPersonId();

            //Assert to be sure the reset acts to reset the personId
            Assert.Equal(expected, result);
        }
    }
}
