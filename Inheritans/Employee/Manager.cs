using Domain;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace Domain
{
    public class Manager : Employee
    {     
        private double Bonus { get; set; }
        public string Departmant { get; set; }
       
       public Manager() 
        {

       }
        public Manager(string name, string surName, double salary, Role role)
        {
            Name = name;
            Surname = surName;
            Salary = salary;
            Role = role;
            //Console.WriteLine($"The name is: {name}, the surname is: {surName}, the salary is: {salary}, and bnous: {bonus}");
            
        }

      
        public void AddBonus(double bonus)
        {
            Bonus = bonus;
        }

        public override double GetSalary()
        {          
            return Salary + Bonus;
        }


  

       












    }
}
