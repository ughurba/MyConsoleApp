using Business.Interfaces;
using DataAccess.Repositoriyes;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Helper;

namespace Business.Service
{
    public class ServiceEmployee : IEmployee
    {
        public static int Count { get; set; }

        EmployeeRepository _employeeRepository = new EmployeeRepository();
        public Employee Create(Employee employee)
        {

            if (employee.Experience >= 2 && employee.Age >= 18 && employee.Age < 30)
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
                Extension.Print(ConsoleColor.Red, "Iw tecrubesi 2 ilden cox ve yawida 18-30 arasi olmalidir");
                return null;
            }

        }

        public Employee Delete(int id)
        {

            Employee EmpDelete = _employeeRepository.GetOne(e => e.Id == id);

            if (EmpDelete == null)
            {
                Extension.Print(ConsoleColor.Red, "Bele id-li employee tapilmadi");
                return null;
            }
            else
            {
                _employeeRepository.Delete(EmpDelete);
                Console.WriteLine();
                Extension.Print(ConsoleColor.Red, $"Id:{EmpDelete.Id}\nName:{EmpDelete.Name}\n" +
                                                 $"Surname:{EmpDelete.Surname}\n" +
                                                 $"Age:{EmpDelete.Age}\n" +
                                                 $"Experience:{EmpDelete.Experience}-il\n" +
                                                 $"Position:{EmpDelete.Position}\n" +
                                                 $"Salary:{EmpDelete.Salary} azn\n" +
                                                 $"Ugurla silindi");
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
                Extension.Print(ConsoleColor.Red, "Bele bir restoran movcud deyil!!!!!!!!");
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
                Extension.Print(ConsoleColor.Red, "Bele bir id-li employee yoxdur!!!!!");
                return null;
            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder();
               
                Extension.Print(ConsoleColor.Green, $"Id:{empId.Id}\nName:{empId.Name}\n" +
                                              $"Surname:{empId.Surname}\n" +
                                              $"Age:{empId.Age}\n" +
                                              $"Experience:{empId.Experience}-il\n" +
                                              $"Position:{empId.Position}\n" +
                                              $"Salary:{empId.Salary} azn\n" +
                                              $"qeyd olundu");
                return empId;
            }
        }

        public Employee UpdatePlaceOfWork(int id, string adress)
        {

            Employee empAdress = _employeeRepository.GetOne(e => e.Id == id);
            if (empAdress == null)
            {
                Extension.Print(ConsoleColor.Red, "Bele bir id-li employee yoxdur!!!!!");
                return null;
            }
            else
            {
                empAdress.RestaurantName = adress;
                Extension.Print(ConsoleColor.Green, "Ugurla update olundu");
                return empAdress;
            }

        }

        public Employee UpdatePosition(string position, int id)
        {
            Employee empPosition = _employeeRepository.GetOne(e => e.Id == id);
            if (empPosition == null)
            {
                Extension.Print(ConsoleColor.Red, "Bele bir id-li employee yoxdur!!!!!");
                return null;
            }
            else
            {
                empPosition.Position = position;
                Extension.Print(ConsoleColor.Green, "Ugurla update olundu");
                return empPosition;
            }

        }

        public Employee UpdateSalary(int salary, int id)
        {



            Employee empSalary = _employeeRepository.GetOne(e => e.Id == id);
            if (empSalary == null)
            {
                Extension.Print(ConsoleColor.Red, "Bele bir id-li employee yoxdur!!!!!");
                return null;
            }
            else
            {
                empSalary.Salary = salary;
                Extension.Print(ConsoleColor.Green, "Ugurla update olundu");
                return empSalary;
            }

        }



        public List<Employee> GetAllEmployeePosition(string restName, string position)
        {
            List<Employee> empList = _employeeRepository.GetAll(e => e.Position == position && e.RestaurantName == restName);
            return empList;

        }
        public bool DeleteByName(string name)
        {

            _employeeRepository.DeleteAll(e => e.RestaurantName == name);
            return true;

        }
    }
}
