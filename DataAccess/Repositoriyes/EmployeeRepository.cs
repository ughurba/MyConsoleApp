﻿using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositoriyes
{
    public class EmployeeRepository : IRepository<Employee>
    {
        public bool Create(Employee entity)
        {
            if(entity == null)
            {
                return false;
            }
            else
            {
                DataContext.employees.Add(entity);  
                return true;
            }
        }

        public bool Delete(Employee Emp)
        {
          
            
            return  DataContext.employees.Remove(Emp);
            
        }

        public bool DeleteAll(Predicate<Employee> emp = null)
        {
            if(emp == null)
            {
                return false;
            }
            else
            {
                DataContext.employees.RemoveAll(emp);
                return true;
            }
        }

        public List<Employee> GetAll(Predicate<Employee> filter = null)
        {
            return filter == null ? DataContext.employees :
                DataContext.employees.FindAll(filter);

                
        }

        public Employee GetOne(Predicate<Employee> filter = null)
        {
            return filter == null ? DataContext.employees[0] :
                DataContext.employees.Find(filter);
        }

        //public bool Update(Employee entity)
        //{
        //    if(entity == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        Employee UpEmploye = GetOne(emp => emp.Id == entity.Id);
        //        UpEmploye = entity;
        //        return true;
        //    }
           
        //}
    }
}
