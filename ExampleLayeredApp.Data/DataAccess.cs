using System;
using System.Collections.Generic;
using ExampleLayeredApp.Entities;

namespace ExampleLayeredApp.Data
{
    public class DataAccess : IDataAccess
    {
        public List<Person> GetData()
        {
            //Use your persistence library to get data here.
            return new List<Person> { new Person("John", "Smith"), new Person("Bob", "Johnson") };
        }
    }
}
