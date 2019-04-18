using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, decimal> departmentSalaries = new Dictionary<string, decimal>();
        List<Employee> employees = new List<Employee>();
        int numberOfEmployees = int.Parse(Console.ReadLine());

        for (int cur = 0; cur < numberOfEmployees; cur++)
        {
            string[] inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = inputTokens[0];
            decimal salary = decimal.Parse(inputTokens[1]);
            string position = inputTokens[2];
            string department = inputTokens[3];
            Employee currEmployee = new Employee(name, salary, position, department);
            if(inputTokens.Length == 5)
            {
                if (inputTokens[4].Contains("@"))
                {
                    currEmployee.Email = inputTokens[4];
                }
                else
                {
                    currEmployee.Age = int.Parse(inputTokens[4]);
                }
            }
            else if(inputTokens.Length == 6)
            {
                currEmployee.Email = inputTokens[4];
                currEmployee.Age = int.Parse(inputTokens[5]);
            }
            employees.Add(currEmployee);
            if (!departmentSalaries.ContainsKey(department))
            {
                departmentSalaries[department] = 0;
            }
            departmentSalaries[department] += salary;
        }

        string departmentWithHighestAverageSalary = departmentSalaries
            .OrderBy(x => -x.Value)
            .First().Key;
        Console.WriteLine($"Highest Average Salary: {departmentWithHighestAverageSalary}");
        foreach (Employee employee in employees
            .Where(e => e.Department == departmentWithHighestAverageSalary)
            .OrderBy(e => -e.Salary))
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
        }
    }
}
