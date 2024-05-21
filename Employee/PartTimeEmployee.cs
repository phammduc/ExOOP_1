using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;

namespace Employee;


    public class PartTimeEmployee : Employee
    {
        public int workingHours;

        public PartTimeEmployee(string name, int paymentPerHour, int workingHours)
            : base(name, paymentPerHour)
        {
            this.workingHours = workingHours;
        }

        public override int CalculateSalary()
        {
            return workingHours * paymentPerHour;
        }

        public override string ToString()
        {
            return base.ToString() + $", Working Hours: {workingHours}, Salary: {CalculateSalary()}";
        }
    }

