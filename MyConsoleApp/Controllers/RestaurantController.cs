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

            Extension.Print(ConsoleColor.Yellow, "Xaiw edirik nece Restaurant acmaq istediyiniz qeyd edin");
            int size = MyExtension.CheckInt();
            for (int i = 0; i < size; i++)
            {

                Extension.Print(ConsoleColor.Yellow, "Restaurant Name qeyd edin");
                string name = MyExtension.CheckCreate();
                Extension.Print(ConsoleColor.Yellow, "Restaurant Adress-in qeyd edin");
                string adress = MyExtension.CheckAdress();


                Restaurant restaurant = new Restaurant()
                {
                    Name = name.ToLower(),
                    Adress = adress.ToLower(),
                };

                if (serviceRestaurant.Creat(restaurant) != null)
                {
                    Extension.Print(ConsoleColor.Green, $"Id:{restaurant.Id}\nName:{restaurant.Name}\n" +
                                             $"Adress:{restaurant.Adress}\n" +
                                             $"acildi");

                }

            }

        }


        public void UpdateByName()
        {

            Extension.Print(ConsoleColor.Yellow, "Id qeyd edin,");
            int id = MyExtension.CheckInt();
            Extension.Print(ConsoleColor.Yellow, "Yeni Restaurant Name qeyd edin");
            string newName = MyExtension.CheckCreate();


            serviceRestaurant.UpdateName(id, newName.ToLower());

        }
        public void UpdateAdress()
        {

            Extension.Print(ConsoleColor.Yellow, "Id qeyd edin,");
            int id = MyExtension.CheckInt();
            Extension.Print(ConsoleColor.Yellow, "Yeni Restaurant Adress qeyd edin");
            string newAdress = MyExtension.CheckAdress();

            serviceRestaurant.UpdateAdress(id, newAdress.ToLower());

        }
        public void GetAll()
        {
            foreach (var item in serviceRestaurant.GetAll())
            {
                Extension.Print(ConsoleColor.Cyan, $"Id:{item.Id}\nName:{item.Name}\n" +
                                               $"Adress:{item.Adress}\n");

            }
        }
        public void Delete()
        {

            Extension.Print(ConsoleColor.Yellow, "Id qeyd edin,");
            int id = MyExtension.CheckInt();
            serviceRestaurant.Delete(id);

        }
        public void GetRestaurantByName()
        {

            Extension.Print(ConsoleColor.Yellow, "Restaurant Name qeyd edin,");
            string name = MyExtension.CheckCreate();

            foreach (var item in serviceRestaurant.GetRestaurantByName(name.ToLower()))
            {
                Extension.Print(ConsoleColor.Cyan, $"Id:{item.Id}\nName:{item.Name}\n" +
                                          $"Adress:{item.Adress}\n");
            }

        }
        public void GetRestaurantById()
        {

            Extension.Print(ConsoleColor.Yellow, "Restaurant Id qeyd edin,");
            int id = MyExtension.CheckInt();
            serviceRestaurant.GetRestaurant(id);

        }
        public void GetAllEmpPositionByRestName()
        {
            ServiceEmployee serviceEmployee = new ServiceEmployee();
            Extension.Print(ConsoleColor.Yellow, "Restaurant name qeyd edin,");
            string restName = MyExtension.CheckCreate();
            Extension.Print(ConsoleColor.Yellow, "Position qeyd edin\n1-oficant\n2-Ashbaz\n3-Barmen\n4-muhafizeci");
            string pos = null;
            int position = MyExtension.CheckInt();
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
                Extension.Print(ConsoleColor.Green, $"Id:{item.Id}\nName:{item.Name}\n" +
                                                        $"Surname:{item.Surname}\n" +
                                                        $"Age:{item.Age}\n" +
                                                        $"Position:{item.Position}\n" +
                                                        $"Salary:{item.Salary} azn\n" +
                                                        $"Qeyd olduqu tarix:{item.dateTime}\n" +
                                                        $"Experience:{item.Experience}-il\n" +
                                                        $"Work:{item.RestaurantName}");
            }
        }
    }
}
