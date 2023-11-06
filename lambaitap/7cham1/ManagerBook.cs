using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _7cham1
{
    internal class ManagerBook
    {
        //public void Addbook(List<Book> books)
        //{
        //    Book book = new Book();

        //    Console.WriteLine("Nhap id:");
        //    book.Id = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Nhap title:");
        //    book.Title = Console.ReadLine();
        //    Console.WriteLine("Nhap Author:");
        //    book.Author = Console.ReadLine();
        //    Console.WriteLine("Nhap Publisher:");
        //    book.Publisher = Console.ReadLine();
        //    Console.WriteLine("Nhap Year:");
        //    book.Year = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Nhap Prince:");
        //    book.Prince = Convert.ToInt32(Console.ReadLine());

        //    books.Add(book);
        //}

        public void deleteBook(List<Book> books)
        {
            Book book = new Book();

            Console.WriteLine("Nhap id can xoa:");
            int choice = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < books.Count; i++)
            {
                if (choice == books[i].Id)
                {
                    Console.WriteLine("Check");
                    books.RemoveAt(i);
                }
            }

            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine(books[i]);
            }
        }

        public void sortbyPrice(List<Book> books)
        {
            books.Sort();
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void searchbyName(List<Book> books)
        {
            Console.WriteLine("Nhap ten can tim kiem: ");
            string name = Console.ReadLine();

            for (int i = 0;i < books.Count;i++)
            {
                if (books[i].Title.Equals(name))
                    Console.WriteLine(books[i]);
            }
        }

        public void showbookyear2014(List<Book> books)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Year.Equals(2014))
                    Console.WriteLine(books[i]);
            }
        }

        public void removeAuthorNhiDong(List<Book> books)
        {
            string publisher = "Nhi Dong";
            for (int i = 0; i < books.Count; ++i)
            {
                if (books[i].Publisher.Equals(publisher))
                    Console.WriteLine(books[i]);
            }
        }
    }
}
