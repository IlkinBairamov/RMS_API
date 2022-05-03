using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Exceptions
{
    public class AlreadyFullException : Exception
    {
        public AlreadyFullException(string msg) : base(msg)
        {

        }
    }
}
