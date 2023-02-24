using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Exceptions
{
    class NegativeInputException :Exception
    {
        public override string Message => "Input number must be greater than 0.";
    }
}
