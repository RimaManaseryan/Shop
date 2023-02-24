using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Exceptions
{
    class StatusInactiveException : Exception
    {
        public override string Message => "Your order process cannot be done while your status is inactive";
    }
}
