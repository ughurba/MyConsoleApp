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
    public class ServiceTable : ITable
    {
        TableRepository _tableRepository = new TableRepository();
        public static int Count { get; set; }
        public Table Create(Table table)
        {
            Count++;
            table.Id = Count;
            _tableRepository.Create(table);
            return table;
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
