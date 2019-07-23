using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveCopy
{
    public abstract class Storage
    {
        protected string CarrierName { get; set; }
        protected string Model { get; set; }

        public abstract int GetMomorySize();
        public abstract string CopyData();
        public abstract int GetFreeMomorySize();
        public abstract string GetFullCarrierInfo();
      
    }
}
