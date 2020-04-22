using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Person
    {
        public string _FirstName { get; private set; }
        public string _LastName { get; private set; }

        public Person(string firstName, string lastName)
        {
            _FirstName = firstName;
            _LastName = lastName;
        }

        public void PrintName()
        {
            Console.WriteLine("\n{0} {1}", _FirstName, _LastName);
        }
    }
}
