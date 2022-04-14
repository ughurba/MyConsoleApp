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
    public class ServiceEmployee : IEmployee
    {
        public static int Count{get ; set;}

        EmployeeRepository _employeeRepository = new EmployeeRepository();
        public Employee Create(Employee employee)
        {
            if (employee.Experience >= 2)
            {
                Count++;
                employee.Id = Count;
                _employeeRepository.Create(employee);
            ;
                return employee;
            }
            else
            {
                Console.WriteLine();
                return null;
            }
       

        }

        public Employee Delete(int id)
        {
           Employee Emp = _employeeRepository.GetOne(e => e.Id == id);
           _employeeRepository.Delete(Emp);
            return Emp;

        }

        public List<Employee> GetAll()
        {
           return _employeeRepository.GetAll();

        }

        public List<Employee> GetAllEmployeeByRestName(string restaurantName = null)
        {
            return _employeeRepository.GetAll(e => e.RestaurantName == restaurantName);
        }

        public Employee GetEmployee(int id)
        {
         return  _employeeRepository.GetOne(e => e.Id == id);
        }

        public Employee UpdatePlaceOfWork(int id, string adress)
        {
           Employee empAdress = _employeeRepository.GetOne(e => e.Id == id);
            empAdress.RestaurantName = adress;
            return empAdress;  
        }

        public Employee UpdatePosition(string position,int id)
        {
           Employee empPosition=  _employeeRepository.GetOne(e => e.Id == id);
            empPosition.Position = position;
            return empPosition;
        }

        public Employee UpdateSalary(int salary, int id)
        {
            Employee empSalary = _employeeRepository.GetOne(e => e.Id == id);
            empSalary.Salary = salary;
            return empSalary;
        }
    }
}
