namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEmployee> employees = new List<IEmployee>();

            // Add some employees to the list
            employees.Add(new PartTimeEmployee("Alice", 15, 20));
            employees.Add(new FullTimeEmployee("Bob", 25));
            employees.Add(new PartTimeEmployee("Charlie", 12, 25));
            employees.Add(new FullTimeEmployee("David", 30));

            // Menu
            bool running = true;
            while (running)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add a new employee");
                Console.WriteLine("2. Find the highest salary");
                Console.WriteLine("3. Find employee by name");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddEmployee(employees);
                        break;
                    case 2:
                        FindHighestSalary(employees);
                        break;
                    case 3:
                        FindEmployeeByName(employees);
                        break;
                    case 4:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddEmployee(List<IEmployee> employees)
        {
            Console.Write("Enter employee type (FullTime/PartTime): ");
            string type = Console.ReadLine();
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            int paymentPerHour;
            while (true)
            {
                try
                {
                    Console.Write("Enter payment per hour: ");
                    paymentPerHour = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            if (type.Equals("FullTime", StringComparison.OrdinalIgnoreCase))
            {
                employees.Add(new FullTimeEmployee(name, paymentPerHour));
            }
            else if (type.Equals("PartTime", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Enter working hours: ");
                int workingHours = int.Parse(Console.ReadLine());
                employees.Add(new PartTimeEmployee(name, paymentPerHour, workingHours));
            }
            else
            {
                Console.WriteLine("Invalid employee type. Please enter either 'FullTime' or 'PartTime'.");
            }
        }

        static void FindHighestSalary(List<IEmployee> employees)
        {
            var highestSalaryEmployee = employees.OrderByDescending(emp => emp.CalculateSalary()).FirstOrDefault();
            if (highestSalaryEmployee != null)
            {
                Console.WriteLine("Employee with the highest salary:");
                Console.WriteLine(highestSalaryEmployee);
            }
            else
            {
                Console.WriteLine("No employees found.");
            }
        }

        static void FindEmployeeByName(List<IEmployee> employees)
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();
            var employee = employees.FirstOrDefault(emp => emp.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));
            if (employee != null)
            {
                Console.WriteLine("Employee found:");
                Console.WriteLine(employee);
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }
}
