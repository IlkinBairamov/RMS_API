using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Exceptions
{
    internal class TableIsReservedException : Exception
    {
        public TableIsReservedException(string msg): base(msg)
        {

        }
    }
}
