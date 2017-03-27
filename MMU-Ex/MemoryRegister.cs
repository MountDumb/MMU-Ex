using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMU_Ex
{
    public class MemoryRegister
    {
        bool[] _adresses;
        public MemoryRegister()
        {
            _adresses = new bool[100];
        }
    }
}
