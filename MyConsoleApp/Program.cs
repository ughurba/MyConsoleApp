using Business.Service;
using Entities.Models;
using MyConsoleApp.Controllers;
using System;
using Utilities.Helper;

namespace MyConsoleApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
               
            ServiceClient serviceClient = new ServiceClient();
            ServiceTable serviceTable = new ServiceTable();
            ServiceEmployee serviceEmployee = new ServiceEmployee();
            ServiceRestaurant serviceRestaurant = new ServiceRestaurant();
            
            PrintAndEnum.Print(ConsoleColor.Green, "WELCOME TO OUR RESTAURANT");
            CreateRestaurant();
            CreateTable();
        
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
    }
}
