using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Todoapp.Data;
using Todoapp.Model;

namespace Todoapp.Test
{
    public class TodoItemTest
    {
        [Fact]
        public void TodoArrayLength()
        {
            //Arrange
            TodoItems newTodoItems = new TodoItems();
            newTodoItems.Clear();
            newTodoItems.NewTodo("This is Description");
            int expected = 1;
            //Act 
            int actual = newTodoItems.Size();


            //Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void FindAll()
        {
            //Arrange
            TodoItems newTodoItems = new TodoItems();
            newTodoItems.Clear();
            newTodoItems.NewTodo("This is Description");
            newTodoItems.NewTodo("This is not a Description");


            //act
            Todo[] actual = newTodoItems.FindAll();

            //Assert
            Assert.Equal("This is Description", actual[0].Description);
            Assert.Equal("This is not a Description", actual[1].Description);

        }
        [Fact]
        public void FindByIdExistingTodo()
        {
            //Arrange
            TodoItems newTodoItems = new TodoItems();
            newTodoItems.Clear();
            newTodoItems.NewTodo("This is Description");

            //act
            Todo expected = newTodoItems.FindAll()[0];
            Todo actual = newTodoItems.FindById(expected.TodoId);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact] // FindByIdNonExistingTodo
        public void FindByIdNonExistingTodo()
        {
            //Arrange
            TodoItems newTodoItems = new TodoItems();
            newTodoItems.Clear();
            newTodoItems.NewTodo("This is Description");

            // Act

            Todo actual = newTodoItems.FindById(2); ;
            Todo expected = null;

            //Assert
            Assert.Equal(expected, actual);

        }
        [Fact]  // ResizeTodoArray
        public void TestNewTodoArray()
        {
            //Arrange
            TodoItems newTodoItems = new TodoItems();
            newTodoItems.Clear();
            newTodoItems.NewTodo("This is Description");
            int expectedSize = 1;
            //Act 
            int actualSize = newTodoItems.Size();
            Todo actualTodo = newTodoItems.FindAll()[0];
            //Assert
            Assert.Equal(expectedSize, actualSize);
            Assert.Equal("This is Description", actualTodo.Description);            
        }
    }
}