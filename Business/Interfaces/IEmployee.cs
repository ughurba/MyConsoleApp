using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IEmployee
    {
        Employee Create(Employee employee);
        Employee Delete(int id);
        bool DeleteByName(string name);
        Employee UpdateSalary(int salary ,int id);
        Employee UpdatePosition(string position,int id);
        Employee UpdatePlaceOfWork(int id,string adress);
        Employee GetEmployee(int id);
        List<Employee> GetAll();
        List<Employee> GetAllEmployeeByRestName(string restaurantName = null);


    }
}
