using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Todoapp.Data
{
    public class PersonSequencer
    {

        public static int personId; // int is 0

        public static int NextPersonId()
        {
            return ++personId;
        }
        public static void Reset()
        {
            personId = 0;
            
        }















    }
}










