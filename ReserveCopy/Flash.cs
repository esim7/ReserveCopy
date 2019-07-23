using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveCopy
{
    public class Flash 
    {
        protected double WriteSpeed;
        protected double ReadSpeed;
        protected int MemorySize;

        public Flash(int _MemorySize)
        {
            WriteSpeed = 35.10;
            ReadSpeed = 118.8;
            MemorySize = _MemorySize;
        }

    }
}
