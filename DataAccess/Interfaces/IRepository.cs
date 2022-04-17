using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IRepository<T> where T:IEntity
    {
        bool DeleteAll(Predicate<T> filter =null);
        bool Create(T entity);
        //bool Update(T entity);
        bool Delete(T entity);
        List<T> GetAll(Predicate<T> filter = null);
        T GetOne(Predicate<T> filter = null);




    }
}
