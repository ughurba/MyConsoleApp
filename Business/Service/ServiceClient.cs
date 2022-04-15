using Business.Interfaces;
using DataAccess.Repositoriyes;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class ServiceClient : IClient

    {
        public static int Count { get; set; }
        ClientRepository _clientRepository = new ClientRepository();
        public Client Creat(Client client)
        {
            Count++;
            client.Id = Count;
           _clientRepository.Create(client);
            return client;

        }

        public bool DeleteByName(string name)
        {
          Client clientDelt =  _clientRepository.GetOne(c => c.Name == name);

            _clientRepository.Delete(clientDelt);
            return true;
        }

        public Client UpdateMoney(int id, int money)
        {
            Client clientUp =   _clientRepository.GetOne(c => c.Id == id);
            clientUp.MoneyClient = money;
            return clientUp;
        }
    }
}
