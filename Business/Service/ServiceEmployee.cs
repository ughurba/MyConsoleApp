using Business.Interfaces;
using DataAccess.Repositoriyes;
using Entities.Models;
using System;
using System.Collections.Generic;
using Utilities.Helper;

namespace Business.Service
{
    public class ServiceEmployee : IEmployee
    {
        public static int Count { get; set; }

        EmployeeRepository _employeeRepository = new EmployeeRepository();
        public Employee Create(Employee employee)
        {

            if (employee.Experience >= 2)
            {

                Count++;
                employee.Id = Count;
                employee.dateTime = DateTime.Now;
                _employeeRepository.Create(employee);
                ;
                return employee;
            }
            else
            {
                PrintAndEnum.Print(ConsoleColor.Red, "Iw tecrubesi 2 ilden cox olmalidi!!!");
                return null;
            }

        }

        public Employee Delete(int id)
        {

            Employee EmpDelete = _employeeRepository.GetOne(e => e.Id == id);
            
            if (EmpDelete == null)
            {
                PrintAndEnum.Print(ConsoleColor.Red, "Bele id-li employee tapilmadi");
                return null;
            }
            else
            {
                _employeeRepository.Delete(EmpDelete);
                return EmpDelete;
            }


        }

        public List<Employee> GetAll()
        {

            return _employeeRepository.GetAll();

        }

        public List<Employee> GetAllEmployeeByRestName(string restaurantName = null)
        {


            List<Employee> employeeList = _employeeRepository.GetAll(e => e.RestaurantName == restaurantName);
            if (employeeList.Count == 0)
            {
                PrintAndEnum.Print(ConsoleColor.Red, "Bele bir restoran movcud deyil!!!!!!!!");
                return null;
            }
            else
            {
                return employeeList;
            }
        }

        public Employee GetEmployee(int id)
        {
            Employee empId = _employeeRepository.GetOne(e => e.Id == id);
            if (empId == null)
            {
                PrintAndEnum.Print(ConsoleColor.Red, "Bele bir id-li employee yoxdur!!!!!");
                return null;
            }
            else
            {
                return empId;
            }
        }

        public Employee UpdatePlaceOfWork(int id, string adress)
        {

            Employee empAdress = _employeeRepository.GetOne(e => e.Id == id);
            if (empAdress == null)
            {
                PrintAndEnum.Print(ConsoleColor.Red, "Bele bir id-li employee yoxdur!!!!!");
                return null;
            }
            else
            {
                empAdress.RestaurantName = adress;
                return empAdress;
            }

        }

        public Employee UpdatePosition(string position, int id)
        {
            Employee empPosition = _employeeRepository.GetOne(e => e.Id == id);
            if (empPosition == null)
            {
                PrintAndEnum.Print(ConsoleColor.Red, "Bele bir id-li employee yoxdur!!!!!");
                return null;
            }
            else
            {
                empPosition.Position = position;
                return empPosition;
            }

        }

        public Employee UpdateSalary(int salary, int id)
        {
            Employee empSalary = _employeeRepository.GetOne(e => e.Id == id);
            if (empSalary == null)
            {
                PrintAndEnum.Print(ConsoleColor.Red, "Bele bir id-li employee yoxdur!!!!!");
                return null;
            }
            else
            {
                empSalary.Salary = salary;
                return empSalary;
            }

        }

        public  bool DeleteByName(string name)
        {
          
            _employeeRepository.DeleteAll(e=>e.RestaurantName == name);
            return true;
           
        }
    }
}
