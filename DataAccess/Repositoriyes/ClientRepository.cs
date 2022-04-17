using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositoriyes
{
    public class ClientRepository : IRepository<Client>
    {
        public bool Create(Client entity)
        {
            if (entity == null)
            {
                return false;
            }
            else
            {
                DataContext.clients.Add(entity);
                return true;
            }
        }

        public bool Delete(Client entity)
        {
           DataContext.clients.Remove(entity);
            return true;
        }

        public bool DeleteAll(Predicate<Client> client = null)
        {
            if (client == null)
            {
                return false;
            }
            else
            {
                DataContext.clients.RemoveAll(client);
                return true;
            }
        }

        public List<Client> GetAll(Predicate<Client> filter = null)
        {
            return filter == null ? DataContext.clients :
               DataContext.clients.FindAll(filter);
        }

        public Client GetOne(Predicate<Client> filter = null)
        {
            return filter == null? DataContext.clients[0] :
                DataContext.clients.Find(filter);
        }

        //public bool Update(Client entity)
        //{
        //    if (entity == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        Client UpClient = GetOne(cl => cl.Id == entity.Id);
        //        UpClient = entity;
        //        return true;
        //    }
        //}
    }
}
