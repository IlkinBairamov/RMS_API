using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.HelperServices.Interfaces
{
    public interface IRandomGenerator
    {
        int Generate(int codeLength);
    }
}
