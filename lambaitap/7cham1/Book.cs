using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7cham1
{
    internal class Book:IComparable<Book>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public int Prince { get; set; }

        public Book() { }
        public Book(int Id, string Title, string Author, string Publisher, int Year, int Prince)
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

        public int CompareTo(Book other)
        {
            return this.Prince.CompareTo(other.Prince);
        }
    }
}
