using System;
using System.Collections.Generic;
using System.Text;

namespace Todoapp.Model
{
   public class Todo
    {
        //  Field

        readonly int todoId;
        string description;
        bool done;
        Person assignee;
        public int TodoId 
        {
            get
            {
                return todoId;
            }
                
        }

        public string Description  // property
        {
            get
            {
                return description;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("BAD you have have space or zero input.");
                }
                else
                {
                    description = value;
                }
            }
        }
        public bool Done 
        { 
            get
            {
                return done;
            }
            set
            {
                done = value;
            }
        }
        public Person Assignee
        {
            get
            {
                return assignee;
            }
            set
            {
                assignee = value;
            }
        }

        public Todo(int ID, string desc)  // constructor
        {            
            todoId = ID;
            Description = desc;
        }

    }

}
