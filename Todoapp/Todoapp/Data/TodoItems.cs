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
        public void NewTodo(string desc)
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
            Todo[] doneTodo = new Todo[0];
            foreach (Todo todo in todoArray)
            {
                if (todo.Done == doneStatus)
                {

                    int index = doneTodo.Length;
                    Array.Resize<Todo>(ref doneTodo, index + 1);
                    doneTodo[index] = todo;
                }
            }
            return doneTodo;

        }
        public Todo[] FindByAssginee(int personId)
        {
            Todo[] assigneeTodo = new Todo[0];
            foreach (Todo todo in todoArray)
            {
                if (todo.Assignee.PersonId == personId)
                {

                    int number = assigneeTodo.Length;
                    Array.Resize<Todo>(ref assigneeTodo, number + 1);
                    assigneeTodo[number] = todo;
                }
            }
            return assigneeTodo;
        }
        public Todo[] FindByAssignee(Person assignee)
        {
            // Store the assigneeTodo 
            int personId = assignee.PersonId;
            Todo[] storedAssignee = FindByAssginee(personId);
            return storedAssignee;
        }
        public Todo[] FindUnassignedTodoItem()
        {
            Todo[] storeNullAssignee = new Todo[0];
            foreach (Todo todo in todoArray)
            {
                if (todo.Assignee == null)
                {
                    int number = storeNullAssignee.Length;
                    Array.Resize<Todo>(ref storeNullAssignee, number + 1);
                    storeNullAssignee[number] = todo;

                }
            }
            return storeNullAssignee;

        }
        public void Clear()
        {
            todoArray = new Todo[0];
        }
    }
}








