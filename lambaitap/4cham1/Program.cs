
using _4cham1;

public class Program
{
    public static void Main(string[] args)
    {
        int initialize;
        Console.WriteLine("Nhap so tien can gui:");
        initialize = Convert.ToInt32(Console.ReadLine());

        Account account = new Account(initialize);

        Console.WriteLine($"{account.Deposit(500000)}");
        Console.WriteLine($"{account.WithDraw(1500000)}");

        account = new SavingAccount(initialize);
        var sAcc = (SavingAccount)account;
        sAcc.GetInterest(initialize);


        account = new CheckAccount(account.Balance);

        Console.WriteLine($"{account.Deposit(300000)}");
        Console.WriteLine($"{account.WithDraw(100000)}");
    }
}