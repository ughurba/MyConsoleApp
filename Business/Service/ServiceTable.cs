using Business.Interfaces;
using DataAccess.Repositoriyes;
using Entities.Models;
using System;
using System.Collections.Generic;
using Utilities.Helper;

namespace Business.Service
{
    public class ServiceTable : ITable
    {
        RestaurantRepository restaurantRepository = new RestaurantRepository();
        TableRepository _tableRepository = new TableRepository();
        public static int Count { get; set; }
        public Table Create(Table table)
        {

            Restaurant res = restaurantRepository.GetOne(r => table.RestaurantNameTable == r.Name);
            if (res != null)
            {
                Count++;
                table.Id = Count;
                _tableRepository.Create(table);
                return table;

            }
            else
            {
                Extension.Print(ConsoleColor.Red, "Bele adi restoran yoxdur");

                return null;
            }


        }

        public Table Delete(int id)
        {
            Table tableDel = _tableRepository.GetOne(t => t.Id == id);
            if (tableDel == null)
            {
                Console.WriteLine("bele idli table tapilmadi");
                return null;
            }
            else
            {
                _tableRepository.Delete(tableDel);
                return tableDel;
            }
           
        }

        public List<Table> GetAll()
        {
            return _tableRepository.GetAll();
        }

        public List<Table> GetAllTableByRestName(string restaurantName = null)
        {
            List<Table> tabels = _tableRepository.GetAll(t => t.RestaurantNameTable == restaurantName);
            if(tabels.Count == 0)
            {
                Extension.Print(ConsoleColor.Red, "bele Namde restoran tapilmadi");
                return null;
            }
            else
            {
                return tabels;
            }
           
        }

        public Table GetTable(int id)
        {
            
            Table getTable = _tableRepository.GetOne(t => t.Id == id);
            if (getTable == null)
            {
                Console.WriteLine("bele idli table yoxdur");
                return null;
            }
            else
            {
                Extension.Print(ConsoleColor.Green, $"Id:{getTable.Id}\nTableNo:{getTable.TableNo}\nMoney Table:{getTable.MoneyTabel} azn\n" +
                                                  $"Reservition:{getTable.Reservition}\n" +
                                                  $"Ugurla Update olundu");
                return getTable;
            }
       
        }

        public Table UpdateMoneyTable(int id, int money)
        {
            Table upTabelMoney = _tableRepository.GetOne(t => t.Id == id);
            if(upTabelMoney == null)
            {
                Console.WriteLine("bele idli table tapilmadi");
                return null;
            }
            else
            {
                upTabelMoney.MoneyTabel = money;
                Extension.Print(ConsoleColor.Green, $"Id:{upTabelMoney.Id}\nTableNo:{upTabelMoney.TableNo}\nMoney Table:{upTabelMoney.MoneyTabel} azn\n" +
                                             $"Reservition:{upTabelMoney.Reservition}\n" +
                                             $"Ugurla Update olundu");
                return upTabelMoney;
            }
        
        }

        public Table UpdateTableNo(int id, string tableNo)
        {
            Table upTableNo = _tableRepository.GetOne(t => t.Id == id);
            if(upTableNo == null)
            {
                Console.WriteLine("bele idli table tapilmadi");
                return null;
            }
            else
            {
                upTableNo.TableNo = tableNo;
                Extension.Print(ConsoleColor.Green, $"Id:{upTableNo.Id}\nTableNo:{upTableNo.TableNo}\nMoney Table:{upTableNo.MoneyTabel} azn\n" +
                                                $"Reservition:{upTableNo.Reservition}\n" +
                                                $"Ugurla Update olundu");
            }
        
            return upTableNo;
        }
    }
}
