using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linh
{
    public class Student
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public int DateOfBirth { get; set; }

        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }

        public string Name { get; set; }
        public string Class {  get; set; }
        
        public Student() { }
        public Student(int id, int age, int dateOfBirth, string @class, int mark1, int mark2, int mark3, string name)
        {
            this.Id = id;
            this.Age = age;
            this.DateOfBirth = dateOfBirth;
            this.Class = @class;
            this.Mark1 = mark1;
            this.Mark2 = mark2;
            this.Mark3 = mark3;
            this.Name = name;
        }

        public float mark_AVG()
        {
            float markAVG = 0;
            markAVG += ((Mark1 + Mark2 + Mark3)*1f) / 3;
            return markAVG;
        }

        public void Show(float markAVG)
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Ten: {Name}");
            Console.WriteLine($"Ngay Sinh: {DateOfBirth}");
            Console.WriteLine($"Lop: {Class}");
            Console.WriteLine($"Diem 1: {Mark1} - Diem 2: {Mark2} - Diem 3: {Mark3}");
            Console.WriteLine("Diem trung binh : " + markAVG);
        }
    }
}
