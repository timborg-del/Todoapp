using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Todoapp.Model;
using Xunit;

namespace Todoapp.Test
{
    public class TodoTest

    {

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]

        public void BadDescriptionContructor(string desc) // 
        {
            Assert.Throws<ArgumentException>(() => new Todo(15, desc));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]

        public void BadDescriptionProperty(string description)
        {
           
            Todo whatevername = new Todo(15, "notempt"); // I Have created an obeject of typ TODO by calling constructor gining value 15 and "". / The purpes is to test the Propery in Todo.cs
            Assert.Throws<ArgumentException>(() => whatevername.Description = description);

        }       

    }

}
