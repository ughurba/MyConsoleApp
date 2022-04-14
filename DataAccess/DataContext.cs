using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataContext
    {
        public static List<Restaurant> restaurants { get; set; }
        public static List<Employee> employees { get; set; }
       static DataContext()
        {
            restaurants = new List<Restaurant>();
            employees = new List<Employee>();
        }
    }
}
