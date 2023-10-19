using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4cham3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();

            document.Write("Linh");
            document.Read("Anh");

            string a = document.Encrypt();
            document.Decrypt(a);
        }
    }
}
