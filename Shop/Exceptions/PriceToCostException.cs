﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class PriceToCostException : Exception
    {
        public override string Message => "Price must be greater than Cost.";
        
    }
}
