﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DirectionsEmea.Web.Models
{
    public class GenericResult
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }

        public GenericResult()
        {
            Success = true;
        }
    }

    public class GenericResult<T>: GenericResult
    {
        public T Result { get; set; }
    }
}