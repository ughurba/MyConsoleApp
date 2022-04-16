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
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik nece Restaurant acmaq istediyiniz qeyd edin");
                int size = int.Parse(Console.ReadLine());
                for (int i = 0; i < size; i++)
                {

                    PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Restaurant Name qeyd edin");
                    string name = Console.ReadLine();
                    PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Restaurant Adress-in qeyd edin");
                    string adress = Console.ReadLine();
                   

                    Restaurant restaurant = new Restaurant()
                    {
                        Name = name.ToLower(),
                        Adress = adress.ToLower(),
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
          

                if (newName.CheckCreate(newName))
                {
                    serviceRestaurant.UpdateName(id, newName.ToLower());
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
               

                if (newAdress.CheckAdress(newAdress))
                {
                    serviceRestaurant.UpdateAdress(id, newAdress.ToLower());
                 
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
             
                foreach (var item in serviceRestaurant.GetRestaurantByName(name.ToLower()))
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
        public void GetAllEmpPositionByRestName()
        {
           ServiceEmployee serviceEmployee = new ServiceEmployee();
            PrintAndEnum.Print(ConsoleColor.Yellow, "Restaurant name qeyd edin,");
            string restName = Console.ReadLine();
            PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Position qeyd edin\n1-oficant\n2-Ashbaz\n3-Barmen\n4-muhafizeci");
            string pos = null;
            int position = int.Parse(Console.ReadLine());
            if (position == 1)
            {
                pos = "ofisiant";
            }
            else if (position == 2)
            {
                pos = "ashbaz";
            }
            else if (position == 3)
            {
                pos = "barmen";
            }
            else if (position == 4)
            {
                pos = "muhafizeci";
            }
           
            foreach (var item in serviceEmployee.GetAllEmployeePosition(restName.ToLower(), pos.ToLower()))
            {
                PrintAndEnum.Print(ConsoleColor.Green, $"Id:{item.Id}\nName:{item.Name}\n" +
                                                        $"Surname:{item.Surname}\n" +
                                                        $"Age:{item.Age}\n" +
                                                        $"Position:{item.Position}\n" +
                                                        $"Salary:{item.Salary} azn\n" +
                                                        $"Data:{item.dateTime}\n" +
                                                        $"Experience:{item.Experience}-il\n" +
                                                        $"Work:{item.RestaurantName}");
            }
        }
    }
}
