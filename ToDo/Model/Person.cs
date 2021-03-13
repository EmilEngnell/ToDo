using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Model
{
    class Person
    {
        private string first;
        private string last;

        Person(string firstName, string lastName)
        {
            first = firstName;
            last = lastName;
        }

        private string personID;
    }
}
