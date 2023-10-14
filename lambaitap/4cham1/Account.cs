using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4cham1
{
    public class Account
    {
        public int Balance = 0;

        public Account(int initialize) 
        {
            Balance = initialize;
        }

        public virtual int Deposit(int money)
        {
            Balance += money;
            return Balance;
        }   

        public virtual int WithDraw(int money) 
        {
            if(Balance < money)
            {
                Console.WriteLine("So tien cua ban khong du de rut");
            }           
            else 
            {
                Balance -= money;
            }
            return Balance;
        }

        public virtual void Getbalance() 
        {
            Console.WriteLine($"{Balance}");
        }

    }
}
