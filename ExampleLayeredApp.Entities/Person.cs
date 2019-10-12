using System;

namespace ExampleLayeredApp.Entities
{
    public class Person
    {
        public Person() { }
        public Person(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
