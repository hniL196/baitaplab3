using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3cham1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 7, 2, 3, 4, 5, 6, 10, 8, 9, 1 };


            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.WriteLine("Nhap so nguyen bat ki: ");
            //    ints[i] = Convert.ToInt32(Console.ReadLine());
            //}

            ListNumber listnumber = new ListNumber();
            listnumber.Min(ints);
            listnumber.Reverse(ints);
            listnumber.Arrange(ints);
            listnumber.Search(ints);

        }

        public class ListNumber
        {
            public void Min(int[] ints)
            {
                int min = ints[0];

                for (int i = 1; i < ints.Length; i++)
                {
                    if (ints[i] < min)
                        min = ints[i];
                }
                Console.WriteLine($"Phan tu nho nhat trong mang la :{min}");
            }

            public void Reverse(int[] ints)
            {
                for (int k = ints.Length - 1; k >= 0; k--)
                {
                    Console.Write($"{ints[k]},");
                }
            }

            public void Arrange(int[] ints)
            {
                Array.Sort(ints);

                Console.WriteLine("\n");
                for (int i = 0; i < ints.Length; i++)
                {
                    Console.Write($"{ints[i]},");
                }
                Console.WriteLine("\n");

                for (int i = ints.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{ints[i]},");
                }

                Console.WriteLine("\n");
            }

            public void Search(int[] ints)
            {
                for (int i = 0; i < ints.Length; i++)
                {

                }
            }
        }
    }
}
