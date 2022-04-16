using Business.Service;
using Entities.Models;
using System;
using Utilities.Extension;
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
                    else
                    {
                        Program.CreateRestaurant();
                    }  
                }
          

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Program.CreateRestaurant();
               
                
            }

        }


        public void UpdateByName()
        {
            try
            {
                EnterName:
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Id qeyd edin,");
                int id = int.Parse(Console.ReadLine());
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Yeni Restaurant Name qeyd edin");
                string newName = Console.ReadLine();
                newName.ToLower();

                if (newName.CheckCreate(newName))
                {
                    serviceRestaurant.UpdateName(id, newName);
                }
                else
                {
                    goto EnterName;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }
        public void UpdateAdress()
        {
            try
            {
            EnterName:
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Id qeyd edin,");
                int id = int.Parse(Console.ReadLine());
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Yeni Restaurant Adress qeyd edin");
                string newAdress = Console.ReadLine();
                newAdress.ToLower();

                if (newAdress.CheckAdress(newAdress))
                {
                    serviceRestaurant.UpdateAdress(id, newAdress);
                 
                }
                else
                {
                    goto EnterName;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void GetAll()
        {
            foreach (var item in serviceRestaurant.GetAll())
            {
                PrintAndEnum.Print(ConsoleColor.Cyan, $"Id:{item.Id}\nName:{item.Name}\n" +
                                               $"Adress:{item.Adress}\n");
                                               
            }
        }
        public void Delete()
        {
            try
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Id qeyd edin,");
                int id = int.Parse(Console.ReadLine());
                serviceRestaurant.Delete(id);


            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void GetRestaurantByName()
        {
            try
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Restaurant Name qeyd edin,");
                string name = Console.ReadLine();
                name.ToLower();
                foreach (var item in serviceRestaurant.GetRestaurantByName(name))
                {
                    PrintAndEnum.Print(ConsoleColor.Cyan, $"Id:{item.Id}\nName:{item.Name}\n" +
                                              $"Adress:{item.Adress}\n");
                }
                
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
        }
        public void GetRestaurantById()
        {
            try
            {
           
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Restaurant Id qeyd edin,");
                int id = int.Parse((Console.ReadLine()));
                PrintAndEnum.Print(ConsoleColor.Green, serviceRestaurant.GetRestaurant(id).Name);

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
