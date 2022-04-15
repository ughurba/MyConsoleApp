using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Table:IEntity
    {
        public bool Reservition { get; set; } = true;
        public string RestaurantNameTable { get; set; }
        public int  MoneyTabel { get; set; }
        public string TableNo { get; set; }
        public int Id { get ; set; }
    }
}
