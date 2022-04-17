using Entities.Interface;
using System;
using System.Collections.Generic;

namespace DataAccess.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        bool DeleteAll(Predicate<T> filter = null);
        bool Create(T entity);

        bool Delete(T entity);
        List<T> GetAll(Predicate<T> filter = null);
        T GetOne(Predicate<T> filter = null);




    }
}
