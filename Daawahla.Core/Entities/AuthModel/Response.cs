﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daawahla.Core.Entities.AuthModel
{
    public class Response<T>
    {
        public T Data { get; set; }
        public string message { get; set; }
        public int code { get; set; }
    }
}
