using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helper
{
    public class Extension
    {
        public enum MenuClient
        {
            CreateClient=1,
            DeleteByName,
            UpdateMoney,
            Reservition,
            GetAll,
            MainMenu=0
        }
        public enum MenuTable
        {
            CreateTabel =1,
            DeleteTable,
            GetAll,
            GetAllTableByRestaurantName,
            GetTable,
            UpdateMoneyTable,
            UpdateTableNo,
            MainMenu=0

        }
        public enum MenuEnums
        {
            MenuRestaurant = 1,
            MenuTable,
            MenuEmployee,
            MenuClient
        }
        public enum MenuRestaurant
        {
            CreateRestaurant=1,
            UpdateRestauranByName,
            UpdateAdress,
            Delete,
            GetAll,
            GetRestaurantById,
            GetRestaurantByName,
            GetAllEmpPositionByRestName,
            MainMenu=0
        }
        public enum MenuEmployee
        {
            CreateEmployee=1,
            DeleteEmployee,
            GetAll,
            GetAllEmployeeByRestaurantName,
            GetEmployee,
            UpdatePlaceOfWork,
            UpdatePosition,
            UpdateSalary,
            MainMenu =0
        }
        public static void Print(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
