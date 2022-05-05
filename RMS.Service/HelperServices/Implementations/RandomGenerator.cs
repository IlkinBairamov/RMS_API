using RMS.Service.HelperServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.HelperServices.Implementations
{
    public class RandomGenerator : IRandomGenerator
    {
        public int Generate(int codeLength)
        {
            Random random = new Random();
            int randomLength = 1;
            for (int i = 0; i < codeLength; i++)
            {
                randomLength *= 10;
            }
            int Code = random.Next(randomLength/10, randomLength);
            return Code;
        }
    }
}
