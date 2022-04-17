using Business.Interfaces;
using DataAccess.Repositoriyes;
using Entities.Models;
using System;
using System.Collections.Generic;
using Utilities.Extension;
using Utilities.Helper;

namespace Business.Service
{
    public class ServiceRestaurant : IRestaurant
    {

        public static int Count { get; set; }

        ServiceEmployee serviceEmployee = new ServiceEmployee();
        RestaurantRepository _restaurantRepository = new RestaurantRepository();
        public Restaurant Creat(Restaurant restaurant)
        {

            if (restaurant.Name.CheckCreate(restaurant.Name))
            {
                if (restaurant.Adress.CheckAdress(restaurant.Adress))
                {
                    Count++;
                    restaurant.Id = Count;
                    _restaurantRepository.Create(restaurant);
                    return restaurant;
                }
            }

            return null;

        }

        public Restaurant Delete(int id)
        {

            Restaurant restaurantDelete = _restaurantRepository.GetOne(r => r.Id == id);


            if (restaurantDelete == null)
            {
                Extension.Print(ConsoleColor.Red, "Bele id-li restoran yoxdur");
                return null;
            }
            else
            {
                serviceEmployee.DeleteByName(restaurantDelete.Name);
                _restaurantRepository.Delete(restaurantDelete);
                return restaurantDelete;
            }

        }

        public List<Restaurant> GetAll()
        {
            return _restaurantRepository.GetAll();
        }



        public Restaurant GetRestaurant(int id)
        {
            Restaurant restaurant = _restaurantRepository.GetOne(r => r.Id == id);
            if (restaurant == null)
            {
                Extension.Print(ConsoleColor.Red, "Bele id-li restoran yoxdur");
                return null;
            }
            else
            {
                return restaurant;
            }
        }

        public List<Restaurant> GetRestaurantByName(string name)
        {
            List<Restaurant> restaurants = _restaurantRepository.GetAll(r => r.Name == name);
            if (restaurants.Count == 0)
            {
                Extension.Print(ConsoleColor.Red, "Bele adli restoran yoxdur");
                return null;
            }
            else
            {
                return restaurants;
            }
        }

        public Restaurant UpdateAdress(int id, string adress = null)
        {
            Restaurant restAdress = _restaurantRepository.GetOne(r => r.Id == id);

            if (restAdress == null)
            {
                Extension.Print(ConsoleColor.Red, "Bele id-li restoran tapilmadi");
                return null;
            }
            else
            {
                restAdress.Adress = adress;
                Extension.Print(ConsoleColor.Green, $"Id:{restAdress.Id}\nName:{restAdress.Name}\n" +
                                       $"Adress:{restAdress.Adress}\n" +
                                       $"update olundu");
                return restAdress;
            }
        }

        public Restaurant UpdateName(int id, string name = null)
        {
            Restaurant restName = _restaurantRepository.GetOne(r => r.Id == id);

            if (restName == null)
            {
                Extension.Print(ConsoleColor.Red, "Bele id-li restoran tapilmadi");
                return null;
            }
            else
            {
                restName.Name = name;
                Extension.Print(ConsoleColor.Green, $"Id:{restName.Id}\nName:{restName.Name}\n" +
                                             $"Adress:{restName.Adress}\n" +
                                             $"update olundu");
                return restName;
            }
        }
    }
}
