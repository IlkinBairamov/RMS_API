using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Exceptions
{
    public class AlreadyExistException : Exception
    {
        public AlreadyExistException(string msg) : base(msg)
        {

        }
    }
}
