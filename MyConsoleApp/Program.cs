using Business.Service;
using Entities.Models;
using System;
using Utilities.Helper;

namespace MyConsoleApp
{
    internal class Program
    {
   
        static void Main(string[] args)
        {
            ServiceEmployee serviceEmployee = new ServiceEmployee();
            ServiceRestaurant serviceRestaurant = new ServiceRestaurant();
            Restaurant restaurant = new Restaurant()
            {
                Name = "Baku",
                Adress = "baku"

            };
           
            Restaurant restaurant1 = new Restaurant()
            {
                Name = "BakuXaous",
                Adress = "moskov"

            };
            Restaurant restaurant2 = new Restaurant()
            {
                Name = "Moskva",
                Adress = "ural"

            };
            serviceRestaurant.Creat(restaurant);
            PrintAndEnum.Print(ConsoleColor.Green, $"{restaurant.Id}\n{restaurant.Name} add olundu");
            serviceRestaurant.Creat(restaurant1);
            PrintAndEnum.Print(ConsoleColor.Green, $"{restaurant1.Id}\n{restaurant1.Name} add olundu");
            serviceRestaurant.Creat(restaurant2);
            PrintAndEnum.Print(ConsoleColor.Green, $"{restaurant2.Id}\n{restaurant2.Name} add olundu");

            Employee employee = new Employee()
            {
                Name = "sahil",
                Surname = "Mamedov",
                Salary = 100,
                Position = "officant",
                Experience = 2,
                RestaurantName = "Baku"

            };
            Employee employee1 = new Employee()
            {
                Name = "Orxan",
                Surname = "Mamedov",
                Salary = 100,
                Position = "officant",
                Experience = 2,
                RestaurantName = "Baku"

            };
            Employee employee2 = new Employee()
            {
                Name = "efqan",
                Surname = "Mamedov",
                Salary = 1030,
                Position = "barmen",
                Experience = 3,
                RestaurantName = "Uyut"

            };
            Console.WriteLine();
            Console.WriteLine();
            serviceEmployee.Create(employee);
            PrintAndEnum.Print(ConsoleColor.Green, $"{employee.Id}\n{employee.Name}" +
                $"\n{employee.Surname}" +
                $"\n{employee.Salary}\n" +
                $"{employee.Position}\n" +
                $"{employee.Experience}\n" +
                $"{employee.RestaurantName}\n" +
                $"{employee.dateTime}");
                


            Console.WriteLine();
            Console.WriteLine();


            serviceEmployee.Create(employee1);
            PrintAndEnum.Print(ConsoleColor.Green, $"{employee1.Id}\n{employee1.Name}" +
            $"\n{employee1.Surname}" +
            $"\n{employee1.Salary}\n" +
            $"{employee1.Position}\n" +
            $"{employee1.Experience}\n" +
            $"{employee1.RestaurantName}\n" +
            $"{ employee1.dateTime}"
            );

            Console.WriteLine();
            Console.WriteLine();


            serviceEmployee.Create(employee2);
            PrintAndEnum.Print(ConsoleColor.Green, $"{employee2.Id}\n{employee2.Name}" +
            $"\n{employee2.Surname}" +
            $"\n{employee2.Salary}\n" +
            $"{employee2.Position}\n" +
            $"{employee2.Experience}\n" +
            $"{employee2.RestaurantName}\n" +
            $"{ employee2.dateTime}");

            Console.WriteLine();
            Console.WriteLine();

        



            //serviceRestaurant.Delete(1);
            //foreach (var item in serviceEmployee.GetAll())
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Console.WriteLine("resotaran gore caqirdiqlarim");
            //foreach (var item in serviceEmployee.GetAllEmployeeByRestName("Baku"))
            //{
            //    Console.WriteLine(item.Name);
            //}


            //   Console.WriteLine();
            //   Console.WriteLine();
            //   //update vezifesine gore iwdedi
            //   serviceEmployee.UpdatePosition("barmen", 2);
            //   PrintAndEnum.Print(ConsoleColor.Green, $"{employee1.Id}\n{employee1.Name}" +
            //   $"\n{employee1.Surname}" +
            //   $"\n{employee1.Salary}\n" +
            //   $"{employee1.Position}\n" +
            //   $"{employee1.Experience}\n" +
            //   $"{employee1.RestaurantName}");

            //   serviceEmployee.UpdateSalary(200, 2);
            //   Console.WriteLine();
            //   Console.WriteLine();
            //   PrintAndEnum.Print(ConsoleColor.Green, $"{employee1.Id}\n{employee1.Name}" +
            // $"\n{employee1.Surname}" +
            // $"\n{employee1.Salary}\n" +
            // $"{employee1.Position}\n" +
            // $"{employee1.Experience}\n" +
            // $"{employee1.RestaurantName}");



            //   Console.WriteLine("iw yerin deyiwdim");

            //   serviceEmployee.UpdatePlaceOfWork(2, "Uyut");
            //   PrintAndEnum.Print(ConsoleColor.Green, $"{employee1.Id}\n{employee1.Name}" +
            //$"\n{employee1.Surname}" +
            //$"\n{employee1.Salary}\n" +
            //$"{employee1.Position}\n" +
            //$"{employee1.Experience}\n" +
            //$"{employee1.RestaurantName}");
            //   Console.WriteLine();
            //   Console.WriteLine();





            //Console.WriteLine(serviceEmployee.GetEmployee(2).Name.ToLower());
            //serviceEmployee.UpdatePlaceOfWork(10, "hello");
            //serviceRestaurant.Delete(10);
            //serviceRestaurant.GetRestaurant(10);
            //Console.WriteLine(serviceRestaurant.UpdateAdress(1, "adasd").Name);
            //Console.WriteLine(serviceRestaurant.GetRestaurant(1).Adress);
            //Console.WriteLine(serviceRestaurant.UpdateName(1,"dasdas").Name);




        }
    }
}
