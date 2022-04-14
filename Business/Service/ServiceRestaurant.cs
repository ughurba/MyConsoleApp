using Business.Interfaces;
using DataAccess.Repositoriyes;
using Entities.Models;
using System.Collections.Generic;

namespace Business.Service
{
    public class ServiceRestaurant : IRestaurant
    {
        public static int Count { get; set; }
        RestaurantRepository _restaurantRepository = new RestaurantRepository();
        public Restaurant Creat(Restaurant restaurant)
        {
            _restaurantRepository.Create(restaurant);
            Count++;
            restaurant.Id = Count;
            return restaurant;

        }

        public Restaurant Delete(int id)
        {
            Restaurant restaurant = _restaurantRepository.GetOne(r => r.Id == id);
            _restaurantRepository.Delete(restaurant);
            return restaurant;
        }

        public List<Restaurant> GetAll()
        {
            return _restaurantRepository.GetAll();
        }

        public Restaurant GetRestaurant(int id)
        {
            return _restaurantRepository.GetOne(r => r.Id == id);
        }

        public List<Restaurant> GetRestaurantByName(string name)
        {
            return _restaurantRepository.GetAll(r => r.Name == name);
        }

        public Restaurant UpdateAdress(int id, string adress = null)
        {
            Restaurant restAdress = _restaurantRepository.GetOne(r => r.Id == id);
            restAdress.Adress = adress;
            return restAdress;
        }

        public Restaurant UpdateName(int id, string name = null)
        {
            Restaurant restName = _restaurantRepository.GetOne(r => r.Id == id);
            restName.Name = name;
            return restName;
        }
    }
}
