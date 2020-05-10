using Domain.Enums;
using System;

namespace Domain
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; set; }
        public Role Role{ get; set; }
        public Employee()
        {

        }
        public Employee(string name, string surName, double salary)
        {
            Name = name;
            Surname = surName;
            Salary = salary;
        }
        public  virtual double GetSalary()
        {
            return Salary;
        }
       
    }
}
