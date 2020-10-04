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
        [Fact]
        public void TestFindDoneByStatus()
        {
            //Arrange
            TodoItems todoItem = new TodoItems();
            todoItem.Clear();
            todoItem.NewTodo("String");
            todoItem.NewTodo("Hobo");
            todoItem.NewTodo("Jörge");

            //Hobo is taked out from the list Now i have onely two obejct left
            Todo[] allTodos = todoItem.FindAll();
            allTodos[1].Done = true;
            //Act
            
            //This is catching teknik 
            Todo[] storeFalse = todoItem.FindByDoneStatus(false);
            Todo[] storeTrue = todoItem.FindByDoneStatus(true);

            //Assert 
            Assert.Equal("String", storeFalse[0].Description);
            Assert.Equal("Jörge", storeFalse[1].Description);
            Assert.Equal("Hobo", storeTrue[0].Description);
            Assert.Equal(2, storeFalse.Length);
            Assert.Single(storeTrue);
        }
        [Fact]
        public void TestFindBytodoItem()
        {
            //Arrange
            Person person = new Person(1856, "Garan", "Persson");

            
            TodoItems todoItem = new TodoItems();
            todoItem.Clear();


            todoItem.NewTodo("hahaha"); //0
            todoItem.NewTodo("Some stuff to do"); //1
            todoItem.NewTodo("Hohoho"); //2
             
            Todo[] allTodos = todoItem.FindAll();
            allTodos[1].Assignee = person;
            //act
            Todo[] allAssignee = todoItem.FindByAssignee(person);
            Todo[] Unsigneed = todoItem.FindUnassignedTodoItem();        
            //Assert
            Assert.Equal("Some stuff to do", allAssignee[0].Description);
            Assert.Null(Unsigneed[0].Assignee);
            Assert.Null(Unsigneed[1].Assignee);
       
        }
        [Fact]
        public void RemovePerson()
        {
            //Arrange
            TodoItems todoItem = new TodoItems();
          
            todoItem.Clear();
            todoItem.NewTodo("Decription");
            todoItem.NewTodo("Do");


            //Act
            int size = todoItem.Size();
            Todo[] todos = todoItem.FindAll();

            todoItem.Remove(todos[0]);


            //Assert
            Assert.Equal(size - 1, todoItem.Size());
            Assert.Equal("Do", todoItem.FindAll()[0].Description);

        }

    }
}

    
