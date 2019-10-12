using ExampleLayeredApp.Entities;
using System;
using System.Collections.Generic;

namespace ExampleLayeredApp.Logic
{
    public interface IBusinessLogic
    {
        List<Person> GetData();
    }
}
