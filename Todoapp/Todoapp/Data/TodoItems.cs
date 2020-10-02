using System;
using System.Collections.Generic;
using System.Text;
using Todoapp.Model;

namespace Todoapp.Data
{
   public class TodoItems
    {
        // Camelcase = oneTwoT 
        static Todo[] todoArray = new Todo[0];

        public int Size()
        {
            return todoArray.Length;
        }
        public Todo[] FindAll()
        {
            return todoArray;
        }

        public Todo FindById(int todoId)
        {
            // store person in Todo in todoArray
            foreach (Todo todo in todoArray)
            {
                if (todo.TodoId == todoId)
                {
                    return todo;
                }
            }
            return null;
        }
        //If its not a return type it must be Void 
        public void NewTodo( string desc)
        {
            int number = todoArray.Length;
            int todoId = TodoSequencer.NextToDoId();
            Todo newTodo = new Todo(todoId, desc);
            Array.Resize<Todo>(ref todoArray, number + 1);
            todoArray[number] = newTodo; // put in zero first 
            /*number = 1
             * ++number     Value of number is 2 uses 2 
             * number++     Value of number is 2 uses 1
             * number+1     Value of number is 1 uses 2
             */
        }
        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            return null;

        }

        public void Clear()
        {
            todoArray = new Todo[0]; 
        }
    }
}
