using System.Collections;
using System.ComponentModel;
using static System.Reflection.Metadata.BlobBuilder;

public class Program
{
    public static void Main(string[] args)
    {
        List<Book> books = new List<Book>();
       
        books.Add(new Book(4, "A", "A", "A", 1, 1));

        for (int i = 0; i < books.Count; i++)
        {
            Console.WriteLine(books[i]);
        }

        ManagerBook managerBook = new ManagerBook();

        managerBook.Addbook(books);

        for (int i = 0; i < books.Count; i++)
        {
            Console.WriteLine($"{books[i]} , {i}");
        }

        managerBook.deleteBook(books);

    }
}

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public double Prince { get; set; }

    public Book() { }

    public Book(int Id, string Title, string Author, string Publisher, int Year, double Prince)
    {
        this.Id = Id;
        this.Title = Title;
        this.Author = Author;
        this.Publisher = Publisher;
        this.Year = Year;
        this.Prince = Prince;
    }

    public override string ToString()
    {
        return string.Format($"{Id} - {Title} - {Author} - {Publisher} - {Year} - {Prince}");
    }
}

    public class ManagerBook
{
    public void Addbook(List<Book> books)
    {
        Book book = new Book();

        Console.WriteLine("Nhap id:");
        book.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap title:");
        book.Title = Console.ReadLine();
        Console.WriteLine("Nhap Author:");
        book.Author = Console.ReadLine();
        Console.WriteLine("Nhap Publisher:");
        book.Publisher = Console.ReadLine();
        Console.WriteLine("Nhap Year:");
        book.Year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap Prince:");
        book.Prince = Convert.ToInt32(Console.ReadLine());

        books.Add(book);
    }

    public void deleteBook(List<Book> books)
    {
        Book book = new Book();

        Console.WriteLine("Nhap id can xoa:");
        int choice = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < books.Count; i++)
        {
            if(choice == books[i].Id)
            {
                Console.WriteLine("Check");
                books.RemoveAt(i);
            }
        }

        for (int i = 0;i < books.Count; i++)
        {
            Console.WriteLine(books[i]);
        }
    }
}