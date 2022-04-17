using Entities.Interface;
using System;

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
