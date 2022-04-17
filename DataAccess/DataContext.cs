using Entities.Models;
using System.Collections.Generic;

namespace DataAccess
{
    public class DataContext
    {
        public static List<Restaurant> restaurants { get; set; }
        public static List<Employee> employees { get; set; }
        public static List<Table> tables { get; set; }
        public static List<Client> clients { get; set; }
        static DataContext()
        {
            clients = new List<Client>();
            tables = new List<Table>();
            restaurants = new List<Restaurant>();
            employees = new List<Employee>();
        }
    }
}
