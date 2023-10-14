namespace lab3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book();
            book.Show();
            Console.Write("\n");
            Book book1 = new Book1(1, "a", 123, "nxb");
            book1.Show();
        }

        public class Book
        {
            public int id;
            public string title;
            public int price;
            public string publisher;

            public Book() { }

            public Book(int id, string title, int price, string publisher)
            {
                this.id = id;
                this.title = title;
                this.price = price;
                this.publisher = publisher;
            }

            public int Id
            {
                get { return id; }
            }

            public string Title
            {
                get { return title; }
            }

            public int Price
            {
                get { return price; }
                set { price = value; }
            }
            public string Publisher
            {
                get { return publisher; }
                set { publisher = value; }
            }

            public virtual void Show()
            {
                Console.WriteLine(id);
            }

        }

        public class Book1 : Book
        {
            public Book1(int id, string title, int prince, string publisher) : base(id, title, prince, publisher) { }

            public override void Show()
            {
                Console.WriteLine(id);
                Console.WriteLine(title);
                Console.WriteLine(price);
                Console.WriteLine(publisher);
            }
        }
    }
}