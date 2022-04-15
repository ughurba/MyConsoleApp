using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositoriyes
{
    public class RestaurantRepository : IRepository<Restaurant>
    {
        public bool Create(Restaurant entity)
        {
            if (entity == null)
            {
                return false;
            }
            else
            {
                DataContext.restaurants.Add(entity);
                return true;
            }
        }

        public bool Delete(Restaurant entity)
        {
            if (entity == null)
            {
                return false;
            }
            else
            {
                DataContext.restaurants.Remove(entity);
                return true;
            }
        }

        public bool DeleteAll(Predicate<Restaurant> restDel = null)
        {
            if(restDel == null)
            {
                return false;
            }
            else
            {

                DataContext.restaurants.RemoveAll(restDel);
                return true;
            }
            
        }

        public List<Restaurant> GetAll(Predicate<Restaurant> filter = null)
        {
            return filter == null ? DataContext.restaurants :
                DataContext.restaurants.FindAll(filter);


        }

        public Restaurant GetOne(Predicate<Restaurant> filter = null)
        {
            return filter == null ? DataContext.restaurants[0] :
                DataContext.restaurants.Find(filter);
        }

        public bool Update(Restaurant entity)
        {
            if (entity == null)
            {
                return false;
            }
            else
            {
                Restaurant UpEmploye = GetOne(emp => emp.Id == entity.Id);
                UpEmploye = entity;
                return true;
            }

        }
    }
}
