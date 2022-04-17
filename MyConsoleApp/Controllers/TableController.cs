using Business.Service;
using Entities.Models;
using System;
using Utilities.Extension;
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

            Extension.Print(ConsoleColor.Yellow, "Xaiw edirik nece stol acmaq istediyiniz qeyd edin");
            int size = MyExtension.CheckInt();
            for (int i = 0; i < size; i++)
            {

                Extension.Print(ConsoleColor.Yellow, "Stolun nomresin qeyd edin");
                string tableNo = MyExtension.CheckNull();

                Extension.Print(ConsoleColor.Yellow, "Stolun qiymetin  qeyd edin");
                int moneyTable = MyExtension.CheckInt();
                Extension.Print(ConsoleColor.Yellow, "Hansi Restorana gedecek bu stol hemen restoranin Name qeyd edin");
                string restaurantNameTable = MyExtension.CheckNull();

                Table table = new Table()
                {
                    TableNo = tableNo.ToLower(),
                    MoneyTabel = moneyTable,
                    RestaurantNameTable = restaurantNameTable.ToLower(),
                };

                if (serviceTable.Create(table) != null)
                {
                    Extension.Print(ConsoleColor.Green, $"Id:{table.Id}\nTableNo:{table.TableNo}\nMoney Table:{table.MoneyTabel}\n" +
                                             $"Reservition:{table.Reservition}\n" +
                                             $"qeyd etiyiniz restorana gonderildi");
                }
                else
                {
                    Program.CreateTable();
                }
            }

        }

        public void Delete()
        {

            Extension.Print(ConsoleColor.Yellow, "id qeyd edin");
            int id = MyExtension.CheckInt();
            serviceTable.Delete(id);

        }
        public void GetAll()
        {
            foreach (var item in serviceTable.GetAll())
            {

                Extension.Print(ConsoleColor.Green, $"Id:{item.Id}\nTableNo:{item.TableNo}\nMoney Table:{item.MoneyTabel} azn\n" +
                                            $"Reservition:{item.Reservition}\n");

            }

        }
        public void GetAllTableByRestName()
        {

            Extension.Print(ConsoleColor.Yellow, "Restaurant Name qeyd edin");
            string restName = MyExtension.CheckNull();


            foreach (var item in serviceTable.GetAllTableByRestName(restName.ToLower()))
            {
                Extension.Print(ConsoleColor.Green, $"Id:{item.Id}\nTableNo:{item.TableNo}\nMoney Table:{item.MoneyTabel} azn\n" +
                                           $"Reservition:{item.Reservition}\n");


            }

        }
        public void GetTable()
        {

            Extension.Print(ConsoleColor.Yellow, "Id qeyd edin");
            int id = MyExtension.CheckInt();
            serviceTable.GetTable(id);

        }
        public void UpdateMoneyTable()
        {

            Extension.Print(ConsoleColor.Yellow, "Id qeyd edin");
            int id = MyExtension.CheckInt();
            Extension.Print(ConsoleColor.Yellow, "Money qeyd edin");
            int money = MyExtension.CheckInt();
            serviceTable.UpdateMoneyTable(id, money);

        }
        public void UpdateTableNo()
        {

            Extension.Print(ConsoleColor.Yellow, "Id qeyd edin");
            int id = MyExtension.CheckInt();
            Extension.Print(ConsoleColor.Yellow, "Yeni Table No qeyd edin");
            string newTableNo = MyExtension.CheckNull();

            serviceTable.UpdateTableNo(id, newTableNo.ToLower());

        }
    }
}
