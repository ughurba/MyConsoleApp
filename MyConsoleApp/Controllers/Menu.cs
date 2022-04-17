using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;

namespace MyConsoleApp.Controllers
{
    public class Menu
    {
        public void MenuRestaurant()
        {
            RestaurantController restaurantController = new RestaurantController();
            Extension.Print(ConsoleColor.Green, "-------Menu Restaurant------");
            Console.WriteLine();
            Extension.Print(ConsoleColor.Blue, "1-Create Restaurant\n2-Update Restauran by Name\n" +
            "3-Update Adress\n4-Delete\n5-Get All\n6-Get Restaurant by Id\n7-Get Restaurant by Name\n8-GetAllEmpPositionByRestName\n0-Main menu");
            int chocie = int.Parse(Console.ReadLine());
            switch (chocie)
            {
                case 1:
                    restaurantController.Creat();
                    break;
                case 2:
                    restaurantController.UpdateByName();
                    break;
                case 3:
                    restaurantController.UpdateAdress();
                    break;
                case 4:
                    restaurantController.Delete();
                    break;
                case 5:
                    restaurantController.GetAll();
                    break;
                case 6:
                    restaurantController.GetRestaurantById();
                    break;
                case 7:
                    restaurantController.GetRestaurantByName();
                    break;
                case 8:
                    restaurantController.GetAllEmpPositionByRestName();
                    break;
                case 0:
                    break;
            }
        }
        public void MenuEmployee()
        {
            EmployeeController employeeController = new EmployeeController();
            Extension.Print(ConsoleColor.Green, "-------Menu Employee------");
            Console.WriteLine();
            Extension.Print(ConsoleColor.Blue, "1-Create Employee\n2-Delete Employee\n" +
                                  "3-Get All\n4-Get All Employee By Restaurant Name\n5-Get Employee\n6-Update Place Of Work\n7-Update Position\n" +
                                  "8-Update Salary\n0-Main menu");
            int chocie3 = int.Parse(Console.ReadLine());
            switch (chocie3)
            {
                case 1:
                    employeeController.Creat();
                    break;
                case 2:
                    employeeController.Delete();
                    break;
                case 3:
                    employeeController.GetAll();
                    break;
                case 4:
                    employeeController.GetAllEmployeeByRestName();
                    break;
                case 5:
                    employeeController.GetEmployee();
                    break;
                case 6:
                    employeeController.UpdatePlaceOfWork();
                    break;
                case 7:
                    employeeController.UpdatePosition();
                    break;
                case 8:
                    employeeController.UpdateSalary();
                    break;
                case 0:
                    break;

            }
        }
        public void MenuTable()
        {
            TableController tableController = new TableController();
            Extension.Print(ConsoleColor.Green, "-------Menu Table------");
            Console.WriteLine();
            Extension.Print(ConsoleColor.Blue, "1-Create Tabel\n2-Delete Table\n" +
            "3-Get All\n4-Get All Table By Restaurant Name\n5-Get Table\n6-Update Money Table\n7-Update Table No\n0-Main menu");
            int chocie2 = int.Parse(Console.ReadLine());
            switch (chocie2)
            {

                case 1:
                    tableController.Creat();
                    break;
                case 2:
                    tableController.Delete();
                    break;
                case 3:
                    tableController.GetAll();
                    break;
                case 4:
                    tableController.GetAllTableByRestName();
                    break;
                case 5:
                    tableController.GetTable();
                    break;
                case 6:
                    tableController.UpdateMoneyTable();
                    break;
                case 7:
                    tableController.UpdateTableNo();
                    break;
                case 0:
                    break;

            }
        }
        public void MenuClient()
        {
            ClientController clientController = new ClientController();
            Extension.Print(ConsoleColor.Green, "-------Menu Client------");
            Console.WriteLine();
            Extension.Print(ConsoleColor.Blue, "1-Create Client\n2-Delete By Name\n" +
            "3-Update Money\n4-Reservition\n" +
            "5-Get All" +
            "\n0-Main menu");
            int chocie4 = int.Parse(Console.ReadLine());
            switch (chocie4)
            {
                case 1:
                    clientController.Creat();
                    break;
                case 2:
                    clientController.DeleteByName();
                    break;

                case 3:
                    clientController.UpdateMoney();
                    break;

                case 4:
                    clientController.Reservition();
                    break;
                case 5:
                    clientController.GetAll();
                    break;
                case 0:
                    goto EnterName;
            }
        }
    }
}
