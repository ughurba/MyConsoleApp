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

                _employeeRepository.Create(employee);

                return employee;
            }
            else
            {
                Extension.Print(ConsoleColor.Red, "Iw tecrubesi 2 ilden cox  olmalidir");
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

        public Employee UpdateWork(int id, string adress)
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
                empAdress.dateTime = DateTime.Now;
                Extension.Print(ConsoleColor.Green, $"Id:{empAdress.Id}\nName:{empAdress.Name}\n" +
                                             $"Surname:{empAdress.Surname}\n" +
                                             $"Age:{empAdress.Age}\n" +
                                             $"Experience:{empAdress.Experience}-il\n" +
                                             $"Position:{empAdress.Position}\n" +
                                             $"Salary:{empAdress.Salary} azn\n" +
                                             $"Qeyd olduqu tarix:{empAdress.dateTime}");
                Extension.Print(ConsoleColor.Green, "Ishe qebul olundu");
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
            if(empList.Count == 0)
            {
                Extension.Print(ConsoleColor.Red, "Bu positionda iwci yoxdur!");
                return null;
            }
            else
            {
                return empList;
            }
         

        }
        public bool DeleteByName(string name)
        {

            _employeeRepository.DeleteAll(e => e.RestaurantName == name);
            return true;

        }
    }
}
