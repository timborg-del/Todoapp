using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Todoapp.Data
{
    public class TodoSequencer
    {
        static int todoId;

        public static int NextToDoId()
        {
            return ++todoId;
        }
        public static void Reset()
        {
            todoId = 0;            
        }


















    }//class
}//namespace

        



        
        
         
        



