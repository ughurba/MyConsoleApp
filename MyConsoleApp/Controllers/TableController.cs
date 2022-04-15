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
    }
}
