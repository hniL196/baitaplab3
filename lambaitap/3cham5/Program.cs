namespace lab3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book("Linh", 20, "202", "A");
            book.Show();
            book.flipPageForward();
            book.Show();
            book.flipPageBackward();
            book.Show();

        }

        public class Book
        {
            public string author;
            public int pages;
            public string isbn;
            public string title;
            public int currentPage = 1;

            public Book(string author, int pages, string isbn, string title)
            {
                this.author = author;
                this.pages = pages;
                this.isbn = isbn;
                this.title = title;

            }

            public int flipPageForward()
            {
                currentPage++;
                return currentPage;
            }

            public int flipPageBackward()
            {
                currentPage--;
                return currentPage;
            }

            public void Show()
            {
                Console.WriteLine($"{author},{pages},{isbn},{title},{currentPage}");
            }
        }
    }
}