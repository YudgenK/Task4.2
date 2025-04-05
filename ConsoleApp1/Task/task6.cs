using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task6
    {

        public void Run()
        {
            Console.Write("Введіть логін: ");
            string login = Console.ReadLine();

            Console.Write("Введіть ім'я: ");
            string firstName = Console.ReadLine();

            Console.Write("Введіть прізвище: ");
            string lastName = Console.ReadLine();

            Console.Write("Введіть вік: ");
            int age = int.Parse(Console.ReadLine());

            User user = new User(login, firstName, lastName, age);

            user.ShowInfo();
        }
    }


    class User
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime RegistrationDate { get; }

        public User(string login, string firstName, string lastName, int age)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            RegistrationDate = DateTime.Now;  // Дата заповнення анкети
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Логін: {Login}");
            Console.WriteLine($"Ім'я: {FirstName}");
            Console.WriteLine($"Прізвище: {LastName}");
            Console.WriteLine($"Вік: {Age}");
            Console.WriteLine($"Дата заповнення анкети: {RegistrationDate}");
        }
    }
}

