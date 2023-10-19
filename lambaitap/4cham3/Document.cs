using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4cham3
{
    class Document : IEncryptable, IStorage
    {
       

        public void Read(string fileName)
        {
            Console.WriteLine($"{fileName}");
        }

        public void Write(string fileName)
        {
            Console.WriteLine($"{fileName}");
        }

        public string Encrypt() 
        {
            string passWordIn;
            Console.WriteLine("Moi ban nhap Mat Khau :");
            passWordIn = Convert.ToString( Console.ReadLine() );
            Console.WriteLine($"{passWordIn}");
            return passWordIn;
        }
        public void Decrypt(string passWordIn)
        {
            string passWordKey = "abc";

            if (passWordIn == passWordKey)
                Console.WriteLine("Ban da nhap dung mat khau");
            else
                Console.WriteLine("Ban da nhap sai mat khau");
        }


    }
}
