﻿using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Employee : Person, IEntity
    {
      
        public string Position { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public string RestaurantName { get; set; }
       public DateTime dateTime { get; set; }
    }
}
