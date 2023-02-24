﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Exceptions
{
    class ItemExistsException:Exception
    {
        public override string Message => "Item already exists.";
    }
}
