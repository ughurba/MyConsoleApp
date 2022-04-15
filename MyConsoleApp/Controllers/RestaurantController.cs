using Business.Service;
using Entities.Models;
using System;
using Utilities.Helper;

namespace MyConsoleApp.Controllers
{
    public class RestaurantController
    {
        private ServiceRestaurant serviceRestaurant;

        public RestaurantController()
        {
            serviceRestaurant = new ServiceRestaurant();
        }
        public void Creat()
        {
                try
                {


                    PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik nece  Restaurant acmaq istediyiniz qeyd edin");
                    int size = int.Parse(Console.ReadLine());
                    for (int i = 0; i < size; i++)
                    {

                        PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Restaurant Name qeyd edin");
                        string name = Console.ReadLine();
                        name.ToLower();
                        PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Restaurant Adress-in qeyd edin");
                        string adress = Console.ReadLine();
                        adress.ToLower();

                        Restaurant restaurant = new Restaurant()
                        {
                            Name = name,
                            Adress = adress,
                        };

                        if (serviceRestaurant.Creat(restaurant) != null)
                        {
                            PrintAndEnum.Print(ConsoleColor.Green, $"Id:{restaurant.Id}\nName:{restaurant.Name}\n" +
                                                     $"Adress:{restaurant.Adress}\n" +
                                                     $"acildi");
                        }
                    }

                }
                catch (Exception ex)
                {
                  Program.CreateRestaurant();
                    Console.WriteLine(ex.Message);

                }
            
        }
    }
}
