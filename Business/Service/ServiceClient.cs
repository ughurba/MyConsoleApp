using Business.Interfaces;
using DataAccess.Repositoriyes;
using Entities.Models;
using System;
using System.Collections.Generic;
using Utilities.Helper;

namespace Business.Service
{
    public class ServiceClient : IClient

    {
        TableRepository _tableRepository = new TableRepository();
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
            Client clientDelt = _clientRepository.GetOne(c => c.Name == name);

            _clientRepository.Delete(clientDelt);
            return true;
        }

        public Client UpdateMoney(int id, int money)
        {
            Client clientUp = _clientRepository.GetOne(c => c.Id == id);
            clientUp.MoneyClient += money;
            return clientUp;
        }

        public Client Reservition(int id, string tableNo)
        {
            Client client = _clientRepository.GetOne(c => c.Id == id);
            Table table = _tableRepository.GetOne(t => t.TableNo == tableNo);

            if (client == null)
            {
                Extension.Print(ConsoleColor.Red, $"Bele id-li wexs tapilmadi ");
                return null;
            }
            else if (table == null)
            {
                Extension.Print(ConsoleColor.Red, $"Bele nomreli stolumuz yoxdur");
                return null;
            }
            else
            {
                if (table.Reservition == "boshdur")
                {
                    if (client.MoneyClient >= table.MoneyTabel)
                    {
                        table.Reservition = client.Name;
                        client.MoneyClient -= table.MoneyTabel;
                        Extension.Print(ConsoleColor.Green, $" {table.TableNo} № stol {client.Name} terfden Reservition oldu");

                        return client;
                    }
                    else
                    {
                        Extension.Print(ConsoleColor.Red, $"bu wexsin pulu catmir bu stolu zakaz etmeye , bu stolun qiymeti {table.MoneyTabel} azn");
                        return null;
                    }
                }
                else
                {
                    Extension.Print(ConsoleColor.Red, $"Cox tessufki {table.TableNo} № stolumuz Reservition olunub");
                    return null;
                }
            }

        }

        public List<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }
    }
}
