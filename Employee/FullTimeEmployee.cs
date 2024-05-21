using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour)
            : base(name, paymentPerHour)
        {
        }

        public override int CalculateSalary()
        {
            return 8 * paymentPerHour;
        }

        public override string ToString()
        {
            return base.ToString() + $", Salary: {CalculateSalary()}";
        }
    }
}
