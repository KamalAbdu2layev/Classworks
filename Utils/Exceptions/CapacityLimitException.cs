using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.Exceptions
{
    internal class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message):base(message)
        {
                
        }
    }
}
