using System;
using Domain;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Dragan";
            employee.Surname = "Tashev";
            employee.Salary = 8000;

            Manager manager = new Manager("Dragan", "Tashev", 8000, Domain.Enums.Role.Manager);


            Console.ReadLine();
            
        }
        
    }
}
