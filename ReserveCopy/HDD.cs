using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveCopy
{
    public class HDD 
    {
        protected double WriteSpeed;
        protected double ReadSpeed;
        protected int SectionCount;
        protected int SectionMemorySize;

        public HDD(int _SectionMemorySize, int _SectionCount)
        {
            WriteSpeed = 30.31;
            ReadSpeed = 34.70;
            SectionCount = _SectionCount;
            SectionMemorySize = _SectionMemorySize;
        }
    }
}
