﻿using Business.Interfaces;
using DataAccess.Repositoriyes;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
          
           Restaurant res =  restaurantRepository.GetOne(r => table.RestaurantNameTable == r.Name);
            if(res != null)
            {

                if (table.TableNo.Length >= 3)
                {
                    Count++;
                    table.Id = Count;
                    _tableRepository.Create(table);
                    return table;
                }
                else
                {
                    PrintAndEnum.Print(ConsoleColor.Red, "Stolun No 3 herifden cox olmalidir");
                    return null;
                }

            }
            else
            {
                PrintAndEnum.Print(ConsoleColor.Red, "Bele adi restoran yoxdur");

                return null;
            }
            

        }

        public Table Delete(int id)
        {
           Table tableDel= _tableRepository.GetOne(t => t.Id == id);
            _tableRepository.Delete(tableDel);
            return tableDel;
        }

        public List<Table> GetAll()
        {
          return   _tableRepository.GetAll();
        }

        public List<Table> GetAllTableByRestName(string restaurantName = null)
        {
          List<Table> tabels =  _tableRepository.GetAll(t => t.RestaurantNameTable == restaurantName);
            return tabels;
        }

        public Table GetTable(int id)
        {
           return _tableRepository.GetOne(t => t.Id == id);
        }

        public Table UpdateMoneyTable(int id, int money)
        {
            Table upTabelMoney = _tableRepository.GetOne(t => t.Id == id);
            upTabelMoney.MoneyTabel = money;
            return upTabelMoney;
        }

        public Table UpdateTableNo(int id, string tableNo)
        {
            Table upTableNo = _tableRepository.GetOne(t => t.Id == id);
            upTableNo.TableNo = tableNo;
            return upTableNo;
        }
    }
}