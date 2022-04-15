using Business.Service;
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
    }
}
