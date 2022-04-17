using Business.Service;
using Entities.Models;
using System;
using Utilities.Extension;
using Utilities.Helper;

namespace MyConsoleApp.Controllers
{
    public class ClientController
    {
        ServiceClient serviceClient;
        public ClientController()
        {
            serviceClient = new ServiceClient();
        }


        public void Creat()
        {

            Extension.Print(ConsoleColor.Yellow, "Xaiw edirik nece muwteri qeyd etmek iseyirsinize onu qeyd edin");
            int size = MyExtension.CheckInt();
            for (int i = 0; i < size; i++)
            {

                Extension.Print(ConsoleColor.Yellow, "Mushterinin adin qeyd edin");
                string name = MyExtension.CheckCreate();

                Extension.Print(ConsoleColor.Yellow, "Surname qeyd edin");
                string surname = MyExtension.CheckCreate();

                Extension.Print(ConsoleColor.Yellow, "Yawin qeyd edin");
                int age = MyExtension.CheckIntAge();

                Extension.Print(ConsoleColor.Yellow, "Pulun qeyd edin");
                int moneyClient = MyExtension.CheckInt(); ;
                Client client = new Client()
                {
                    Name = name.ToLower(),
                    Surname = surname.ToLower(),
                    Age = age,
                    MoneyClient = moneyClient

                };

                if (serviceClient.Creat(client) != null)
                {
                    Extension.Print(ConsoleColor.Green, $"Id:{client.Id}\nName:{client.Name}\n" +
                                             $"Surname:{client.Surname}\n" +
                                             $"Age:{client.Age}\n" +
                                             $"Money:{client.MoneyClient}\n" +
                                             $"qeyd olundu");
                }
                else
                {
                    Program.CreateClient();
                }
            }


        }
        public void DeleteByName()
        {

            Extension.Print(ConsoleColor.Yellow, "Xaiw edirik Muwterinin Name qeyd edin");
            string nameClient = MyExtension.CheckNull();

            serviceClient.DeleteByName(nameClient.ToLower());
        }
        public void UpdateMoney()
        {

            Extension.Print(ConsoleColor.Yellow, "Id qeyd edin");
            int id = MyExtension.CheckInt();
            Extension.Print(ConsoleColor.Yellow, "Pulu qeyd edin");
            int money = MyExtension.CheckInt();
            serviceClient.UpdateMoney(id, money);

        }
        public void Reservition()
        {

            Extension.Print(ConsoleColor.Yellow, "Id qeyd edin");
            int id = MyExtension.CheckInt();
            Extension.Print(ConsoleColor.Yellow, "Xaish edirik hansi stolu reserv etmek isetyirsinizse o stolun nomresin qeyd edin");
            string tableNo = MyExtension.CheckNull();

            serviceClient.Reservition(id, tableNo.ToLower());

        }
        public void GetAll()
        {
            foreach (var item in serviceClient.GetAll())
            {
                Extension.Print(ConsoleColor.Cyan, $"Id:{item.Id}\nName:{item.Name}\n" +
                                               $"Surname:{item.Surname}\nAge:{item.Age}\nMoney:{item.MoneyClient}");


            }
        }
    }
}
