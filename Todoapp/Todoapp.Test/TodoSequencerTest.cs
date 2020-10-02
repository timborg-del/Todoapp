using System;
using System.Collections.Generic;
using System.Text;
using Todoapp.Data;
using Xunit;

namespace Todoapp.Test
{
    public class TodoSequencerTest
    {
        [Fact]
        public void IncresTodoTest()
        {
            // Arrange
            int oldvalue = TodoSequencer.NextToDoId();
            int expectation = oldvalue + 1; //This my own countup add oldvalue to + 1 and thats my expectation

            // Act
            int newvalue = TodoSequencer.NextToDoId();

            // Asser
            Assert.Equal(expectation, newvalue);

        }
        [Fact]

        public void ResetTodoTest()
        {
            //Arrange
            int expected = 1;
            // Adding upp todoId so i know reset method is doing its job.
            for (int i = 0; i < 10; i++)
            {
                TodoSequencer.NextToDoId();
            }
            //Act
            //Pushing the Reset Button when we have added 10 to todoID  
            TodoSequencer.Reset();
            // taking out actual number after reset
            int actual = TodoSequencer.NextToDoId();
            //Assurt
            Assert.Equal(expected, actual);
        }
    }
}
