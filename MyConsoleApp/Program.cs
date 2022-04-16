using Business.Service;
using Entities.Models;
using MyConsoleApp.Controllers;
using System;
using Utilities.Extension;
using Utilities.Helper;

namespace MyConsoleApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            RestaurantController restaurantController = new RestaurantController();
            //ServiceClient serviceClient = new ServiceClient();
            //ServiceTable serviceTable = new ServiceTable();
            //ServiceEmployee serviceEmployee = new ServiceEmployee();
            //ServiceRestaurant serviceRestaurant = new ServiceRestaurant();
            //RestaurantController restaurantController = new RestaurantController();


            PrintAndEnum.Print(ConsoleColor.Green, "WELCOME TO OUR RESTAURANT");

            CreateRestaurant();
            CreateTable();
            CreateEmployee();
            CreateClient();

            PrintAndEnum.Print(ConsoleColor.Blue, "1-Menu Restaurant\n2-Menu Table\n" +
                "3-Menu Employee\n4-Menu Client");
            int num = int.Parse(Console.ReadLine());
            while (true)
            {
                switch (num)
                {
                    case 1:
                        PrintAndEnum.Print(ConsoleColor.Blue, "1-Create Restaurant\n2-Update Restauran by Name\n" +
                        "3-Update Adress\n4-Delete\n5-Get All\n6-Get Restaurant by Id\n7-Get Restaurant by Name\n");
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


                        }















                        break;
                    case 2:




                        break;


                    case 3:


                        break;


                    case 4:



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
                    int  num = int.Parse(Console.ReadLine()) ;
               
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
