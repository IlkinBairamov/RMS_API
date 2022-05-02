using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.Exceptions
{
    public class FileFormatException : Exception
    {
        public FileFormatException(string msg): base(msg)
        {

        }
    }
}
