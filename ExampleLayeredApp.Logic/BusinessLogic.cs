using ExampleLayeredApp.Data;
using ExampleLayeredApp.Entities;
using System;
using System.Collections.Generic;

namespace ExampleLayeredApp.Logic
{
    public class BusinessLogic : IBusinessLogic
    {

        private readonly IDataAccess _dataAccess;

        public BusinessLogic(IDataAccess dataAccess) 
        {
            _dataAccess = dataAccess;
        }
        public List<Person> GetData()
        {
            return _dataAccess.GetData();
        }

    }
}
