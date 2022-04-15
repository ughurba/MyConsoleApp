using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ITable
    {

        Table Create(Table table);
        Table Delete(int id);

        Table UpdateTableNo(int id, string tableNo);

        List<Table> GetAll();

        Table GetTable(int id);
        Table UpdateMoneyTable(int id, int money);

        List<Table> GetAllTableByRestName(string restaurantName = null);

 
    }
}
