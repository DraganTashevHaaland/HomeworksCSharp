using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Constructor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
        
    }
}
