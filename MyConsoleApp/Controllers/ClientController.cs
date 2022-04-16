using Business.Service;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            try
            {

                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik nece iwci goturmek isdediyinizi qeyd edin");
                int size = int.Parse(Console.ReadLine());
                for (int i = 0; i < size; i++)
                {

                    PrintAndEnum.Print(ConsoleColor.Yellow, "Mushterinin adin qeyd edin");
                    string name = Console.ReadLine();
                    name.ToLower();
                    PrintAndEnum.Print(ConsoleColor.Yellow, "Surname qeyd edin");
                    string surname = Console.ReadLine();
                    surname.ToLower();
                    PrintAndEnum.Print(ConsoleColor.Yellow, " yawin qeyd edin");
                    int age = int.Parse(Console.ReadLine());
             
                    PrintAndEnum.Print(ConsoleColor.Yellow, "pulun qeyd edin");
                    int moneyClient = int.Parse(Console.ReadLine());
                    Client client = new Client()
                    {
                        Name = name,
                        Surname = surname,                        
                        Age = age,
                        MoneyClient = moneyClient
                        
                    };

                    if (serviceClient.Creat(client) != null)
                    {
                        PrintAndEnum.Print(ConsoleColor.Green, $"Id:{client.Id}\nName:{client.Name}\n" +
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
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Program.CreateTable();

            }


        }
        public void DeleteByName()
        {
            try
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Muwterinin Name qeyd edin");
                string nameClient = Console.ReadLine();
                nameClient.ToLower();
                serviceClient.DeleteByName(nameClient);

            }catch(Exception ex)
            {
                PrintAndEnum.Print(ConsoleColor.Red, ex.Message);
            }
           

        }
        public void UpdateMoney()
        {
            try
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik id qeyd edin");
                int id = int.Parse(Console.ReadLine());
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Pulu qeyd edin");
                int money = int.Parse(Console.ReadLine());
                serviceClient.UpdateMoney(id, money);
            }catch(Exception ex)
            {
                PrintAndEnum.Print(ConsoleColor.Red, ex.Message);
            }
         
        }
        public void Reservition()
        {
            try
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik id qeyd edin");
                int id = int.Parse(Console.ReadLine());
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaish edirik hansi stolu reserv etmek isetyirsinizse o stolun nomresin qeyd edin");
                string tableNo = Console.ReadLine();
                tableNo.ToLower();  
                serviceClient.Reservition(id, tableNo);
            }catch(Exception ex)
            {
                PrintAndEnum.Print(ConsoleColor.Red,ex.Message);

            }

        }
        public void GetAll()
        {
            foreach (var item in serviceClient.GetAll())
            {
                PrintAndEnum.Print(ConsoleColor.Cyan, $"Id:{item.Id}\nName:{item.Name}\n" +
                                               $"Surname:{item.Surname}\nAge:{item.Age}\nMoney:{item.MoneyClient}");
                                               

            }
        }
    }
}
