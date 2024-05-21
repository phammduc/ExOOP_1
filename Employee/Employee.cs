using System;
using System.Collections.Generic;
using System.Linq;
using Employee;

namespace Employee;



public abstract class Employee : IEmployee
{
    public string name;
    public int paymentPerHour;

    public Employee(string name, int paymentPerHour)
    {
        this.name = name;
        this.paymentPerHour = paymentPerHour;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetPaymentPerHour(int paymentPerHour)
    {
        this.paymentPerHour = paymentPerHour;
    }

    public int GetPaymentPerHour()
    {
        return paymentPerHour;
    }

    public abstract int CalculateSalary();

    public override string ToString()
    {
        return $"Name: {name}, Payment Per Hour: {paymentPerHour}";
    }
}