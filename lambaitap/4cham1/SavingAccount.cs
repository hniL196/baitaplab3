using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4cham1
{
    public class SavingAccount : Account
    {
        float rate = 4.5f;
        public SavingAccount(int initialize) : base(initialize) { }

        public float GetInterest(int initialize) 
        {
            float interest = 0;
            interest = initialize * rate;     
            return interest;
        }
    }
}
