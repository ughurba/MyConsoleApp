using Business.Service;
using Entities.Models;
using System;
using Utilities.Extension;
using Utilities.Helper;
using static Utilities.Helper.Extension;

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

            Extension.Print(ConsoleColor.Yellow, "Xaiw edirik nece iwci goturmek isdediyinizi qeyd edin");
            int size = MyExtension.CheckInt();
            for (int i = 0; i < size; i++)
            {

                Extension.Print(ConsoleColor.Yellow, "Name qeyd edin");
                string name = MyExtension.CheckNull();

                Extension.Print(ConsoleColor.Yellow, "Surname qeyd edin");
                string surname = MyExtension.CheckNull();

                Extension.Print(ConsoleColor.Yellow, "Age qeyd edin");
                int age = MyExtension.CheckIntAge();
                Extension.Print(ConsoleColor.Yellow, "ish tecrubesin qeyd edin");
                int ex = MyExtension.CheckInt();
                Extension.Print(ConsoleColor.Yellow, "Position qeyd edin\n1-oficant\n2-Ashbaz\n3-Barmen\n4-muhafizeci");
                string pos = null;
                int position = MyExtension.CheckInt();
                if (position == (int)Position.ofisiant)
                {
                    pos = "ofisiant";
                }
                else if (position == (int)Position.ashbaz)
                {
                    pos = "ashbaz";
                }
                else if (position == (int)Position.barmen)
                {
                    pos = "barmen";
                }
                else if (position == (int)Position.muhafizeci)
                {
                    pos = "muhafizeci";
                }
                Extension.Print(ConsoleColor.Yellow, "Salary qeyd edin");
                int salary = MyExtension.CheckInt();
                Employee employee = new Employee()
                {
                    Name = name.ToLower(),
                    Surname = surname.ToLower(),
                    Age = age,
                    Experience = ex,
                    Position = pos,
                    Salary = salary

                };

                if (serviceEmployee.Create(employee) != null)
                {

                    Extension.Print(ConsoleColor.Green, $"Id:{employee.Id}\nName:{employee.Name}\n" +
                                             $"Surname:{employee.Surname}\n" +
                                             $"Age:{employee.Age}\n" +
                                             $"Experience:{employee.Experience}-il\n" +
                                             $"Position:{employee.Position}\n" +
                                             $"Salary:{employee.Salary} azn\n" +
                                             $"qeyd olundu");
                }
                else
                {
                    Program.CreateEmployee();
                }
            }
        }
        public void Delete()
        {

            Extension.Print(ConsoleColor.Yellow, "id qeyd edin");
            int id = MyExtension.CheckInt();
            serviceEmployee.Delete(id);
        }
        public void GetAll()
        {
            foreach (var item in serviceEmployee.GetAll())
            {
                Extension.Print(ConsoleColor.Green, $"Id:{item.Id}\nName:{item.Name}\n" +
                                               $"Surname:{item.Surname}\n" +
                                               $"Age:{item.Age}\n" +
                                               $"Position:{item.Position}\n" +
                                               $"Salary:{item.Salary} azn\n" +
                                               $"Experience:{item.Experience}-il\n" +
                                               $"Work:{item.RestaurantName}");
                Console.WriteLine();
                Console.WriteLine();
            }

        }
        public void GetAllEmployeeByRestName()
        {

            Extension.Print(ConsoleColor.Yellow, "Xaiw edirik Restaurant Name qeyd edin");
            string restName = MyExtension.CheckNull();
            foreach (var item in serviceEmployee.GetAllEmployeeByRestName(restName))
            {
                Extension.Print(ConsoleColor.Green, $"Id:{item.Id}\nName:{item.Name}\n" +
                                                   $"Surname:{item.Surname}\n" +
                                                   $"Age:{item.Age}\n" +
                                                   $"Position:{item.Position}\n" +
                                                   $"Salary:{item.Salary} azn\n" +
                                                   $"Qeyd olduqu tarix:{item.dateTime}\n" +
                                                   $"Experience:{item.Experience}-il\n" +
                                                   $"Work:{item.RestaurantName}");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        public void GetEmployee()
        {

            Extension.Print(ConsoleColor.Yellow, "id qeyd edin");
            int id = MyExtension.CheckInt();
            serviceEmployee.GetEmployee(id);

        }
        public void UpdateWork()
        {

            Extension.Print(ConsoleColor.Yellow, "id qeyd edin");
            int id = MyExtension.CheckInt();
            Extension.Print(ConsoleColor.Yellow, "Ish yerinin Name yazin");
            string newAdress = MyExtension.CheckNull();

            serviceEmployee.UpdateWork(id, newAdress.ToLower());

        }
        public void UpdatePosition()
        {
            Extension.Print(ConsoleColor.Yellow, "id qeyd edin");
            int id = MyExtension.CheckInt();
            Extension.Print(ConsoleColor.Yellow, "Position qeyd edin\n1-oficant\n2-Ashbaz\n3-Barmen\n4-muhafizeci");
            string pos = null;
            int position = MyExtension.CheckInt();
            if (position == (int)Position.ofisiant)
            {
                pos = "ofisiant";
            }
            else if (position == (int)Position.ashbaz)
            {
                pos = "ashbaz";
            }
            else if (position == (int)Position.barmen)
            {
                pos = "barmen";
            }
            else if (position == (int)Position.muhafizeci)
            {
                pos = "muhafizeci";
            }
            serviceEmployee.UpdatePosition(pos, id);

        }
        public void UpdateSalary()
        {

            Extension.Print(ConsoleColor.Yellow, "id qeyd edin");
            int id = MyExtension.CheckInt();
            Extension.Print(ConsoleColor.Yellow, "Yeni Mashi  qeyd edin");
            int salary = MyExtension.CheckInt();
            serviceEmployee.UpdateSalary(salary, id);

        }

    }
}
