using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMU_Ex
{
    public class TProcess
    {
        private int _allocatedMemorySize;

        public int AllocatedMemorySize
        {
            get { return _allocatedMemorySize; }
            set
            {
                if (value > 0 && value < 7)
                {
                    _allocatedMemorySize = value;
                }
                else
                {
                    throw new Exception("Memory allocation is outside of the accepted range. Please alocate betweed 1 and 6 pages");
                }
            }
        }


    }
}
