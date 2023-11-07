using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _5cham2
{
    internal class Department
    {
        public string Name { get; set; }

        Employee[] e = new Employee[] { };

        public void Employee(Employee[] e)
        {
            Employee employee = new Employee();

            Console.WriteLine("Nhap ID :");
            employee.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Ten :");

        }
    }
}
