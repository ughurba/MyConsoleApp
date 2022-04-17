using System;
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
                case (int)Extension.MenuRestaurant.CreateRestaurant:
                    restaurantController.Creat();
                    break;
                case (int)Extension.MenuRestaurant.UpdateRestauranByName:
                    restaurantController.UpdateByName();
                    break;
                case (int)Extension.MenuRestaurant.UpdateAdress:
                    restaurantController.UpdateAdress();
                    break;
                case (int)Extension.MenuRestaurant.Delete:
                    restaurantController.Delete();
                    break;
                case (int)Extension.MenuRestaurant.GetAll:
                    restaurantController.GetAll();
                    break;
                case (int)Extension.MenuRestaurant.GetRestaurantById:
                    restaurantController.GetRestaurantById();
                    break;
                case (int)Extension.MenuRestaurant.GetRestaurantByName:
                    restaurantController.GetRestaurantByName();
                    break;
                case (int)Extension.MenuRestaurant.GetAllEmpPositionByRestName:
                    restaurantController.GetAllEmpPositionByRestName();
                    break;
                case (int)Extension.MenuRestaurant.MainMenu:
                    Program.Menu();
                    break;
            }
        }
        public void MenuEmployee()
        {
            EmployeeController employeeController = new EmployeeController();
            Extension.Print(ConsoleColor.Green, "-------Menu Employee------");
            Console.WriteLine();
            Extension.Print(ConsoleColor.Blue, "1-Create Employee\n2-Delete Employee\n" +
                                  "3-Get All\n4-Get All Employee By Restaurant Name\n5-Get Employee\n6-Update Work\n7-Update Position\n" +
                                  "8-Update Salary\n0-Main menu");
            int chocie3 = int.Parse(Console.ReadLine());
            switch (chocie3)
            {
                case (int)Extension.MenuEmployee.CreateEmployee:
                    employeeController.Creat();
                    break;
                case (int)Extension.MenuEmployee.DeleteEmployee:
                    employeeController.Delete();
                    break;
                case (int)Extension.MenuEmployee.GetAll:
                    employeeController.GetAll();
                    break;
                case (int)Extension.MenuEmployee.GetAllEmployeeByRestaurantName:
                    employeeController.GetAllEmployeeByRestName();
                    break;
                case (int)Extension.MenuEmployee.GetEmployee:
                    employeeController.GetEmployee();
                    break;
                case (int)Extension.MenuEmployee.UpdateWork:
                    employeeController.UpdateWork();
                    break;
                case (int)Extension.MenuEmployee.UpdatePosition:
                    employeeController.UpdatePosition();
                    break;
                case (int)Extension.MenuEmployee.UpdateSalary:
                    employeeController.UpdateSalary();
                    break;
                case (int)Extension.MenuEmployee.MainMenu:
                    Program.Menu();
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

                case (int)Extension.MenuTable.CreateTabel:
                    tableController.Creat();
                    break;
                case (int)Extension.MenuTable.DeleteTable:
                    tableController.Delete();
                    break;
                case (int)Extension.MenuTable.GetAll:
                    tableController.GetAll();
                    break;
                case (int)Extension.MenuTable.GetAllTableByRestaurantName:
                    tableController.GetAllTableByRestName();
                    break;
                case (int)Extension.MenuTable.GetTable:
                    tableController.GetTable();
                    break;
                case (int)Extension.MenuTable.UpdateMoneyTable:
                    tableController.UpdateMoneyTable();
                    break;
                case (int)Extension.MenuTable.UpdateTableNo:
                    tableController.UpdateTableNo();
                    break;
                case (int)Extension.MenuTable.MainMenu:
                    Program.Menu();
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
                case (int)Extension.MenuClient.CreateClient:
                    clientController.Creat();
                    break;
                case (int)Extension.MenuClient.DeleteByName:
                    clientController.DeleteByName();
                    break;

                case (int)Extension.MenuClient.UpdateMoney:
                    clientController.UpdateMoney();
                    break;

                case (int)Extension.MenuClient.Reservition:
                    clientController.Reservition();
                    break;
                case (int)Extension.MenuClient.GetAll:
                    clientController.GetAll();
                    break;
                case (int)Extension.MenuClient.MainMenu:
                    Program.Menu();
                    break;
            }
        }
    }
}
