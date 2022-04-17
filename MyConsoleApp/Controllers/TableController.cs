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

                Extension.Print(ConsoleColor.Yellow, "Xaiw edirik nece  stol acmaq istediyiniz qeyd edin");
                int size = int.Parse(Console.ReadLine());
                for (int i = 0; i < size; i++)
                {

                    Extension.Print(ConsoleColor.Yellow, "Xaiw edirik stolun nomresin qeyd edin");
                    string tableNo = Console.ReadLine();

                    Extension.Print(ConsoleColor.Yellow, "Xaiw edirik stolun qiymetin  qeyd edin");
                    int moneyTable = int.Parse(Console.ReadLine());
                    Extension.Print(ConsoleColor.Yellow, "Xaiw edirik Hansi Restauranta gedecek bu stol hemen resotranin Name qeyd edin");
                    string restaurantNameTable = Console.ReadLine();

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
                Extension.Print(ConsoleColor.Yellow, "Xaiw edirik id qeyd edin");
                int id = int.Parse(Console.ReadLine());
                serviceTable.Delete(id);
            }
            catch (Exception ex)
            {
                Extension.Print(ConsoleColor.Yellow, ex.Message);
            }

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
            try
            {
                Extension.Print(ConsoleColor.Yellow, "Xaiw edirik Restaurant Name qeyd edin");
                string restName = Console.ReadLine();


                foreach (var item in serviceTable.GetAllTableByRestName(restName.ToLower()))
                {
                    Extension.Print(ConsoleColor.Green, $"Id:{item.Id}\nTableNo:{item.TableNo}\nMoney Table:{item.MoneyTabel} azn\n" +
                                               $"Reservition:{item.Reservition}\n");


                }


            }
            catch (Exception ex)
            {
                Extension.Print(ConsoleColor.Red, ex.Message);
            }


        }
        public void GetTable()
        {
            try
            {
                Extension.Print(ConsoleColor.Yellow, "Xaiw edirik id qeyd edin");
                int id = int.Parse(Console.ReadLine());
                Extension.Print(ConsoleColor.Green, serviceTable.GetTable(id).TableNo);
            }
            catch (Exception ex)
            {
                Extension.Print(ConsoleColor.Green, ex.Message);
            }


        }
        public void UpdateMoneyTable()
        {
            try
            {
                Extension.Print(ConsoleColor.Yellow, "Xaiw edirik id qeyd edin");
                int id = int.Parse(Console.ReadLine());
                Extension.Print(ConsoleColor.Yellow, "Xaiw edirik money qeyd edin");
                int money = int.Parse(Console.ReadLine());
                serviceTable.UpdateMoneyTable(id, money);
            }
            catch (Exception ex)
            {
                Extension.Print(ConsoleColor.Green, ex.Message);
            }


        }
        public void UpdateTableNo()
        {
            try
            {
                Extension.Print(ConsoleColor.Yellow, "Xaiw edirik id qeyd edin");
                int id = int.Parse(Console.ReadLine());
                Extension.Print(ConsoleColor.Yellow, "Xaiw edirik new Table No qeyd edin");
                string newTableNo = Console.ReadLine();

                serviceTable.UpdateTableNo(id, newTableNo.ToLower());
            }
            catch (Exception ex)
            {
                Extension.Print(ConsoleColor.Green, ex.Message);
            }

        }
    }
}
