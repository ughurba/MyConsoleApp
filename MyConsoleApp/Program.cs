using MyConsoleApp.Controllers;
using System;
using Utilities.Helper;

namespace MyConsoleApp
{
    internal class Program
    {


        static void Main(string[] args)
        {
          
            Extension.Print(ConsoleColor.Green, "WELCOME TO OUR RESTAURANT");
            CreateRestaurant();
            CreateTable();
            CreateEmployee();
            CreateClient();
            Menu();
        }
        public static void Menu()
        {
            Menu menu = new Menu();
        EnterName:
            try
            {
                while (true)
                {
                    Extension.Print(ConsoleColor.Blue, "1-Menu Restaurant\n2-Menu Table\n" + "3-Menu Employee\n4-Menu Client");
                    int num = int.Parse(Console.ReadLine());
                    switch (num)
                    {
                        case (int)Extension.MenuEnums.MenuRestaurant:
                            menu.MenuRestaurant();
                            break;
                        case (int)Extension.MenuEnums.MenuTable:
                            menu.MenuTable();
                            break;
                        case (int)Extension.MenuEnums.MenuEmployee:
                            menu.MenuEmployee();
                            break;
                        case (int)Extension.MenuEnums.MenuClient:
                            menu.MenuClient();
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                Extension.Print(ConsoleColor.Red, ex.Message);
                goto EnterName;
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
                    Extension.Print(ConsoleColor.Blue, "1-Creat Table");
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
                    Extension.Print(ConsoleColor.Blue, "1-Creat Restaurant");
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
                    Extension.Print(ConsoleColor.Blue, "1-Creat Employee");
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
                    Extension.Print(ConsoleColor.Blue, "1-Creat Client");
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
