using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3cham4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double getincome = 0;
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Test";
            employee.YearOfBirth = 4;
            employee.SalaryLevel = 5;
            employee.basicSalary = 6;

            employee.GetIncome(getincome);
        }

        public class Employee
        {
            private int id;
            private string name;
            private int yearOfBirth;
            private double salaryLevel;
            public double basicSalary;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int YearOfBirth
            {
                get { return YearOfBirth; }
                set { YearOfBirth = value; }
            }
            public double SalaryLevel
            {
                get { return SalaryLevel; }
                set { SalaryLevel = value; }
            }

            public double GetIncome(double getincome)
            {
                getincome = salaryLevel * basicSalary;
                return getincome;
            }

            public void Display()
            {
                Console.WriteLine($"Ten:{name}");
                Console.WriteLine($"ID:{id}");
                Console.WriteLine($"Nam sinh:{yearOfBirth}");
                Console.WriteLine($"Luong co ban:{basicSalary}");
                Console.WriteLine("Thu Nhap:");

            }
        }
    }
}
