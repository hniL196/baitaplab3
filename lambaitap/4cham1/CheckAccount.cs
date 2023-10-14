using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4cham1
{
    internal class CheckAccount : Account
    {
        public int FeeTransfer = 100;
        public CheckAccount(int Banlace) : base(Banlace) { }

        public override int Deposit(int money) 
        {
            Balance = (Balance + money - FeeTransfer);
            return Balance;
        }

        public override int WithDraw(int money)
        {
            if (Balance < money + FeeTransfer)
            {
                Console.WriteLine("So tien cua ban khong du de rut");
            }
            else
            {
                Balance = (Balance - money - FeeTransfer);
            }
            return Balance;
        }

        public override void Getbalance()
        {
            Console.WriteLine($"{Balance}");
        }

    }
}
