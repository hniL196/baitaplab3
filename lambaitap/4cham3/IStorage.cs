using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4cham3
{
    interface IStorage
    {
        

        void Read(string fileName);
        void Write(string fileName);
    }
}
