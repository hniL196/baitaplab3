class Program
{
    public static void Main(string[] args)
    {
        int year;

        string[] CHI = { "Ty", "Suu","Dan","Mao","Thin","Ty",
                            "Ngo","Mui","Than","Dau","Tuat","Hoi" };

        string[] CAN = {"Giap","At","Binh","Dinh","Mau",
                            "Ky","Canh","Tan","Nham","Quy" };

        Console.WriteLine("Moi ban nhap nam:");
        year = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine($"Nam nay la nam {CAN[year % 10]} {CHI[year % 12]}");
    }
}