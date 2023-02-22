using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNibble
{
    internal class SwapNibbles
    {
        public int Swap(int binary)
        {
            int result = (binary & 0x0F) << 4 | (binary & 0xF0) >> 4;
            return result;
        }
    }
}
