﻿using Business.Service;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;

namespace MyConsoleApp.Controllers
{
    public class EmployeeController
    {
        ServiceEmployee serviceEmployee;
        public EmployeeController()
        {
            serviceEmployee = new ServiceEmployee();
        }
        public void Creat()
        {
            try
            {

                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik nece iwci goturmek isdediyinizi qeyd edin");
                int size = int.Parse(Console.ReadLine());
                for (int i = 0; i < size; i++)
                {

                    PrintAndEnum.Print(ConsoleColor.Yellow, "ishcinin adin qeyd edin");
                    string name = Console.ReadLine();
                    name.ToLower();
                    PrintAndEnum.Print(ConsoleColor.Yellow, "Surname qeyd edin");
                    string surname = Console.ReadLine();
                    surname.ToLower();
                    PrintAndEnum.Print(ConsoleColor.Yellow, "Iwcinin yawin qeyd edin");
                    int age = int.Parse(Console.ReadLine());
                    PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik ish tecrubesin qeyd edin");
                    int ex = int.Parse(Console.ReadLine());
                    PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Position qeyd edin\n1-oficant\n2-Ashbaz\n3-Barmen\n4-muhafizeci");
                    string pos = null;
                    int position = int.Parse(Console.ReadLine());
                    if(position == 1)
                    {
                        pos = "ofisiant";
                    }
                    else if (position == 2)
                    {
                        pos = "ashbaz";
                    }
                    else if(position == 3)
                    {
                        pos = "barmen";
                    }else if(position == 4)
                    {
                        pos = "muhafizeci";
                    }
                    PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik ne qeder iwci maaw istediyin qeyd edin");
                    int salary = int.Parse(Console.ReadLine());
                    Employee employee = new Employee()
                    {
                        Name = name,
                        Surname = surname,
                        Age = age,
                        Experience = ex,
                        Position = pos,
                        Salary = salary
                        
                    };

                    if (serviceEmployee.Create(employee) != null)
                    {
                        PrintAndEnum.Print(ConsoleColor.Green, $"Id:{employee.Id}\nName:{employee.Name}\n" +
                                                 $"Surname:{employee.Surname}\n" +
                                                 $"Age:{employee.Age}\n" +
                                                 $"Experience:{employee.Experience}\n" +
                                                 $"Position:{employee.Position}\n" +
                                                 $"Salary:{employee.Salary}\n" +
                                                 $"qeyd olundu");
                    }
                    else
                    {
                        Program.CreateEmployee();
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Program.CreateEmployee();

            }


        }
        public void Delete()
        {
            try
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik id qeyd edin");
                int id = int.Parse(Console.ReadLine());
                serviceEmployee.Delete(id);

            }catch (Exception ex)
            {
                PrintAndEnum.Print(ConsoleColor.Red,ex.Message);
            }
           

        }
        public void GetAll()
        {
            try
            {

                foreach (var item in serviceEmployee.GetAll())
                {
                    PrintAndEnum.Print(ConsoleColor.Green, $"Id:{item.Id}\nName:{item.Name}\n" +
                                                   $"Surname:{item.Surname}\n" +
                                                   $"Age:{item.Age}\n" +
                                                   $"Position:{item.Position}\n" +
                                                   $"Salary:{item.Salary}\n" +
                                                   $"Data:{item.dateTime}\n" +
                                                   $"Experience:{item.Experience}\n" +
                                                   $"Work:{item.RestaurantName}");
                    Console.WriteLine();
                    Console.WriteLine();
                }

            }
            catch (Exception ex)
            {

            }
        }
        public void GetAllEmployeeByRestName()
        {
            try
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Restaurant name qeyd edin");
                string restName = Console.ReadLine();
                foreach (var item in serviceEmployee.GetAllEmployeeByRestName(restName))
                {
                    PrintAndEnum.Print(ConsoleColor.Green, $"Id:{item.Id}\nName:{item.Name}\n" +
                                                       $"Surname:{item.Surname}\n" +
                                                       $"Age:{item.Age}\n" +
                                                       $"Position:{item.Position}\n" +
                                                       $"Salary:{item.Salary}\n" +
                                                       $"Data:{item.dateTime}\n" +
                                                       $"Experience:{item.Experience}\n" +
                                                       $"Work:{item.RestaurantName}");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }catch (Exception ex)
            {
                PrintAndEnum.Print(ConsoleColor.Red,ex.Message);
            }
        
        }
        public void GetEmployee()
        {
            try
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaish edirik id qeyd edin");
                int id = int.Parse(Console.ReadLine());
                PrintAndEnum.Print(ConsoleColor.Green,serviceEmployee.GetEmployee(id).Name);

            }
            catch (Exception ex)
            {
                PrintAndEnum.Print(ConsoleColor.Red, ex.Message);
            }
         

        }
        public void UpdatePlaceOfWork()
        {
            try
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik id qeyd edin");
                int id = int.Parse(Console.ReadLine());
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaish edirik yeni Ish yerinin Name yazin");
                string newAdress = Console.ReadLine();
                newAdress.ToLower();
                serviceEmployee.UpdatePlaceOfWork(id, newAdress);
            }catch (Exception ex)
            {
                PrintAndEnum.Print(ConsoleColor.Red, ex.Message);
            }
       


        }
        public void UpdatePosition()
        {
            try
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaish edirik id qeyd edin");
                int id = int.Parse(Console.ReadLine());
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Position qeyd edin\n1-oficant\n2-Ashbaz\n3-Barmen\n4-muhafizeci");
                string pos = null;
                int position = int.Parse(Console.ReadLine());
                if (position == 1)
                {
                    pos = "ofisiant";
                }
                else if (position == 2)
                {
                    pos = "ashbaz";
                }
                else if (position == 3)
                {
                    pos = "barmen";
                }
                else if (position == 4)
                {
                    pos = "muhafizeci";
                }
                serviceEmployee.UpdatePosition(pos, id);
            }catch(Exception ex)
            {
                PrintAndEnum.Print(ConsoleColor.Red,ex.Message);
            }
      

        }
        public void UpdateSalary()
        {
            try
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik id qeyd edin");
                int id = int.Parse(Console.ReadLine());
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Yeni Mashi  qeyd edin");
                int salary = int.Parse(Console.ReadLine());
                serviceEmployee.UpdateSalary(salary, id);
            }catch(Exception ex)
            {
                PrintAndEnum.Print(ConsoleColor.Red, ex.Message);
            }  
          
        }
        public void DeleteByName()
        {
            try
            {
                PrintAndEnum.Print(ConsoleColor.Yellow, "Xaiw edirik Name qeyd edin");
                string name = Console.ReadLine();
                name.ToLower();
                serviceEmployee.DeleteByName(name);

            }catch(Exception ex)
            {
                PrintAndEnum.Print(ConsoleColor.Red, ex.Message);
            }
           
        }
    }
}
