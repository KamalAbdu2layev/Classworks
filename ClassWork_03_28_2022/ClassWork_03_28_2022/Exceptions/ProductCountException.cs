using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork_03_28_2022.Exceptions
{
    class ProductCountException:Exception
    {
        public ProductCountException(string message) : base(message)
        {

        }
    }
}
