﻿using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Table:IEntity
    {
        public string TableNo { get; set; }
        public int Id { get ; set; }
    }
}