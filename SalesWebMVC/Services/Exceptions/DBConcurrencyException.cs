﻿using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class DBConcurrencyException : ApplicationException
    {
        public DBConcurrencyException(string message) : base(message)
        {
        }
    }
}
