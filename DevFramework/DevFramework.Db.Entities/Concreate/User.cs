﻿using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Db.Entities.Concreate
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirsName { get; set; }

        public string Email { get; set; }


    }
}