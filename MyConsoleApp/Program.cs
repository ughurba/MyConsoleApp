using MyConsoleApp.Controllers;
using System;
using Utilities.Helper;

namespace MyConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            EmployeeController employeeController = new EmployeeController();
            TableController tableController = new TableController();
            RestaurantController restaurantController = new RestaurantController();
            ClientController clientController = new ClientController();

            PrintAndEnum.Print(ConsoleColor.Green, "WELCOME TO OUR RESTAURANT");

            CreateRestaurant();
            CreateTable();
            CreateEmployee();
            CreateClient();
        EnterName:
            PrintAndEnum.Print(ConsoleColor.Blue, "1-Menu Restaurant\n2-Menu Table\n" +
                "3-Menu Employee\n4-Menu Client");
            int num = int.Parse(Console.ReadLine());
            while (true)
            {
                switch (num)
                {
                    case 1:
                        PrintAndEnum.Print(ConsoleColor.Blue, "1-Create Restaurant\n2-Update Restauran by Name\n" +
                        "3-Update Adress\n4-Delete\n5-Get All\n6-Get Restaurant by Id\n7-Get Restaurant by Name\n0-Main menu");
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
                            case 0:
                                goto EnterName;
                        }
                        break;
                    case 2:
                        PrintAndEnum.Print(ConsoleColor.Blue, "1-Create Tabel\n2-Delete Table\n" +
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
                                goto EnterName;

                        }
                        break;
                    case 3:
                        PrintAndEnum.Print(ConsoleColor.Blue, "1-Create Employee\n2-Delete Employee\n" +
                                              "3-Get All\n4-Get All Employee By Restaurant Name\n5-Get Employee\n6-Update Place Of Work\n7-Update Position\n" +
                                              "8-Update Salary\n9-Delete By Name\n0-Main menu");
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
                            case 9:
                                employeeController.DeleteByName();
                                break;
                            case 0:
                                goto EnterName;

                        }
                        break;
                    case 4:
                        PrintAndEnum.Print(ConsoleColor.Blue, "1-Create Client\n2-Delete By Name\n" +
                        "3-Update Money\n4-Reservition\n0-Main menu");
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
                            case 0:
                                goto EnterName;
                        }

                        break;

                }
            }

        }
        public static void CreateTable()
        {

            TableController tableController = new TableController();
            int num;
            while (true)
            {
                try
                {
                    PrintAndEnum.Print(ConsoleColor.Blue, "1-Creat Table");
                    num = int.Parse(Console.ReadLine());

                    if (num == 1)
                    {
                        tableController.Creat();
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static void CreateRestaurant()
        {
            RestaurantController restaurantController = new RestaurantController();

            while (true)
            {
                try
                {
                    PrintAndEnum.Print(ConsoleColor.Blue, "1-Creat Restaurant");
                    int num = int.Parse(Console.ReadLine());

                    if (num == 1)
                    {
                        restaurantController.Creat();
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static void CreateEmployee()
        {
            EmployeeController employeeController = new EmployeeController();
            while (true)
            {
                try
                {
                    PrintAndEnum.Print(ConsoleColor.Blue, "1-Creat Employee");
                    int num = int.Parse(Console.ReadLine());

                    if (num == 1)
                    {
                        employeeController.Creat();
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static void CreateClient()
        {
            ClientController clientController = new ClientController();
            while (true)
            {
                try
                {
                    PrintAndEnum.Print(ConsoleColor.Blue, "1-Creat Client");
                    int num = int.Parse(Console.ReadLine());

                    if (num == 1)
                    {
                        clientController.Creat();
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
