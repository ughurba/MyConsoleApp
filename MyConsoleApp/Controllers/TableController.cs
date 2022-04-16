using Business.Service;
using Entities.Models;
using System;
using Utilities.Helper;

namespace MyConsoleApp.Controllers
{
    public class TableController
    {
        private ServiceTable serviceTable;
        public TableController()
        {
            serviceTable = new ServiceTable();
        }


        public void Creat()
        {
            try
            {

                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik nece  Stol acmaq istediyiniz qeyd edin");
                int size = int.Parse(Console.ReadLine());
                for (int i = 0; i < size; i++)
                {

                    PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik stolun nomresin qeyd edin");
                    string tableNo = Console.ReadLine();
                    tableNo.ToLower();
                    PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Stolun qiymetin  qeyd edin");
                    int moneyTable = int.Parse(Console.ReadLine());
                    PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Hansi Restauranta gedecek bu stol hemen resotranin Name qeyd edin");
                    string restaurantNameTable = Console.ReadLine();
                    Table table = new Table()
                    {
                        TableNo = tableNo,
                        MoneyTabel = moneyTable,
                        RestaurantNameTable = restaurantNameTable
                    };

                    if (serviceTable.Create(table) != null)
                    {
                        PrintAndEnum.Print(ConsoleColor.Green, $"Id:{table.Id}\nMoney Table:{table.MoneyTabel}\n" +
                                                 $"Reservition:{table.Reservition}\n" +
                                                 $"acildi");
                    }
                    else
                    {
                        Program.CreateTable();
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Program.CreateTable();

            }


        }

        public void Delete()
        {
            try
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik id qeyd edin");
                int id = int.Parse(Console.ReadLine());
                serviceTable.Delete(id);
            }catch(Exception ex)
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, ex.Message);
            }
      
        }
        public void GetAll()
        {
            foreach (var item in serviceTable.GetAll())
            {
                PrintAndEnum.Print(ConsoleColor.Green, $"Id:{item.Id}\nMoney Table:{item.MoneyTabel}\n" +
                                                 $"Reservition:{item.Reservition}\n");

            }
            
        }
        public  void GetAllTableByRestName()
        {
            try
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Restaurant Name qeyd edin");
                string restName = Console.ReadLine();

                foreach (var item in serviceTable.GetAllTableByRestName(restName))
                {
                    PrintAndEnum.Print(ConsoleColor.Green, $"Restaurant Name:{item.RestaurantNameTable}\nId:{item.Id}\nMoney Table:{item.MoneyTabel}\n" +
                                                $"Reservition:{item.Reservition}\n");
                                              
                }
                

            }catch (Exception ex)
            {
                PrintAndEnum.Print(ConsoleColor.Red, ex.Message);
            }
          

        }
        public void GetTable()
        {
            try
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik id qeyd edin");
                int id = int.Parse(Console.ReadLine());
                PrintAndEnum.Print(ConsoleColor.Green, serviceTable.GetTable(id).TableNo);
            }catch (Exception ex)
            {
                PrintAndEnum.Print(ConsoleColor.Green, ex.Message);
            }
          
           
        }
        public void UpdateMoneyTable()
        {
            try
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik id qeyd edin");
                int id = int.Parse(Console.ReadLine());
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik money qeyd edin");
                int money = int.Parse(Console.ReadLine());
                serviceTable.UpdateMoneyTable(id, money);
            }catch(Exception ex)
            {
                PrintAndEnum.Print(ConsoleColor.Green, ex.Message);
            }
          

        }
        public void UpdateTableNo()
        {
            try
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik id qeyd edin");
                int id = int.Parse(Console.ReadLine());
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik new Table No qeyd edin");
                string newTableNo = Console.ReadLine();
                serviceTable.UpdateTableNo(id, newTableNo);
            }catch(Exception ex)
            {
                PrintAndEnum.Print(ConsoleColor.Green, ex.Message);
            }
       
        }
    }
}
