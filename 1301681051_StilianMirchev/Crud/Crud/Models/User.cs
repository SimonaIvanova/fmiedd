﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud.Models
{
    public class User
    {
        public int Id { get; set; }

        public string username { get; set; }

        public string password { get; set; }
       
        public string email { get; set; }
    }
}