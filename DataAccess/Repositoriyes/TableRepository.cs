using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositoriyes
{
    public class TableRepository : IRepository<Table>
    {
        public bool Create(Table entity)
        {
            if (entity == null)
            {
                return false;
            }
            else
            {
                DataContext.tables.Add(entity);
                return true;
            }
        }

        public bool Delete(Table entity)
        {
            DataContext.tables.Remove(entity);
            return true;
        }

        public bool DeleteAll(Predicate<Table> table = null)
        {
            if (table == null)
            {
                return false;
            }
            else
            {
                DataContext.tables.RemoveAll(table);
                return true;
            }
        }

        public List<Table> GetAll(Predicate<Table> filter = null)
        {
            return filter == null ? DataContext.tables :
               DataContext.tables.FindAll(filter);
        }

        public Table GetOne(Predicate<Table> filter = null)
        {
            return filter == null ? DataContext.tables[0] :
                DataContext.tables.Find(filter);
        }

        public bool Update(Table entity)
        {
            if (entity == null)
            {
                return false;
            }
            else
            {
                Table UpTable = GetOne(cl => cl.TableNo == entity.TableNo);
                UpTable = entity;
                return true;
            }
        }
    }
}
