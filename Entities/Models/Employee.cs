using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Employee : IEntity
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public string RestaurantName { get; set; }
    }
}
