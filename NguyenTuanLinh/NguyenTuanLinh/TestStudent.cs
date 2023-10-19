using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linh
{
    public class TestStudent
    {
        int Id, Age, DateOfbirth;
        string Name, Class;

        public void InputInformation()
        {
            Console.WriteLine("Nhap id:");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ten:");
            Name = Convert.ToString(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine($"{Id}");
            Console.WriteLine($"{Name}");
        }
    }
}

