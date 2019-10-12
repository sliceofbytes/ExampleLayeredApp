using ExampleLayeredApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleLayeredApp.Data
{
    public interface IDataAccess
    {
        List<Person> GetData();
    }
}
