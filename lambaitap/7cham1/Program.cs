using _7cham1;
using System.Collections;
using System.ComponentModel;
using static System.Reflection.Metadata.BlobBuilder;

public class Program
{
    public static void Main(string[] args)
    {
        List<Book> books = new()
        {
            new Book(1, "A", "Tô Hoài", "Nhà Xuất Bản Trẻ", 2014, 50000),
            new Book(2, "Tắt Đèn", "Ngô Tất Tố", "A", 1941, 79000),
            new Book(3, "Lão Hạc", "Nam Cao", "Nhà Xuất Bản Hội Nhà Văn", 2014, 80000),
            new Book(4, "Những Người Tinh Khôi", "Nguyễn Tuân", "Nhà Xuất Bản Hội Nhà Văn", 1942, 49000),
            new Book(5, "Dế Mèn Phiêu Lưu Ký", "Tô Hoài", "Nhi Dong", 2005, 109000),
            new Book(6, "Bố Già", "Mario Puzo", "Nhà Xuất Bản Thanh Niên", 1969, 50000),
            new Book(7, "Số Đỏ", "Hồ Anh Thái", "Nhà Xuất Bản Kim Đồng", 2014, 150000),
            new Book(8, "Người Mẹ Cầm Súng", "Nguyễn Nhật Ánh", "Nhi Dong", 2001, 129000),
            new Book(9, "Tôi Thấy Hoa Vàng Trên Cỏ Xanh", "Nguyễn Nhật Ánh", "Nhà Xuất Bản Trẻ", 1991, 99000),
            new Book(10, "Dế Mèn Phiêu Lưu Ký", "Tô Hoài", "Nhà Xuất Bản Trẻ", 2005, 100000)
        };

        for (int i = 0; i < books.Count; i++)
        {
            Console.WriteLine(books[i]);
        }

        ManagerBook managerBook = new ManagerBook();

        Console.WriteLine("\nSap xep theo gia tang dan\n");
        managerBook.sortbyPrice(books);

        Console.WriteLine("\nTim kiem theo ten\n");
        managerBook.searchbyName(books);

        Console.WriteLine("\nNhung cuon sach xuat ban nam 2014 la :\n");
        managerBook.showbookyear2014(books);

        Console.WriteLine("\nNha xuat ban Nhi Dong");
        managerBook.removeAuthorNhiDong(books);
    }
}

