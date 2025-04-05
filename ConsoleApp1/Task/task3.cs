using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task3
    {
        public void Run()
        {

            Console.Write("Введіть ім'я співробітника: ");
            string firstName = Console.ReadLine();

            Console.Write("Введіть прізвище співробітника: ");
            string lastName = Console.ReadLine();

            Employee employee = new Employee(firstName, lastName);

            Console.Write("Введіть посаду співробітника: ");
            string position = Console.ReadLine();

            Console.Write("Введіть стаж співробітника (роки): ");
            int experienceYears = int.Parse(Console.ReadLine());

            employee.SetPositionAndExperience(position, experienceYears);

            employee.DisplayEmployeeInfo();
        }
    }

    class Employee
    {
        private string firstName;
        private string lastName;
        private string position;
        private int experienceYears;
        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void SetPositionAndExperience(string position, int experienceYears)
        {
            this.position = position;
            this.experienceYears = experienceYears;
        }
        public double CalculateSalary()
        {
            double baseSalary = 5000; // Базовий оклад

            if (position.ToLower() == "manager")
            {
                baseSalary += 2000;
            }
            else if (position.ToLower() == "developer")
            {
                baseSalary += 1500;
            }
            else if (position.ToLower() == "designer")
            {
                baseSalary += 1200;
            }

            baseSalary += experienceYears * 100;

            return baseSalary;
        }

        public double CalculateTax(double salary)
        {
            double taxRate = 0.15; // Податкова ставка 15%
            return salary * taxRate;
        }

        public void DisplayEmployeeInfo()
        {
            double salary = CalculateSalary();
            double tax = CalculateTax(salary);

            Console.WriteLine($"Співробітник: {firstName} {lastName}");
            Console.WriteLine($"Посада: {position}");
            Console.WriteLine($"Оклад: {salary:F2} UAH");
            Console.WriteLine($"Податковий збір: {tax:F2} UAH");
        }
    }
}