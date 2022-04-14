using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IRestaurant
    {
        Restaurant Creat(Restaurant restaurant);
        Restaurant Delete(int id);
        List<Restaurant> GetAll();
        Restaurant GetRestaurant(int id);
       List <Restaurant> GetRestaurantByName(string name);
        Restaurant UpdateName(int id,string name=null);
        Restaurant UpdateAdress(int id ,string adress=null);
    }
}
