using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4cham3
{
    interface IEncryptable
    {
        string Encrypt();
        void Decrypt(string passWordIn);
    }
}
