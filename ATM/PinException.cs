using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class PinException:ApplicationException
    {
        public PinException(string message2)
        {
            Message2 = message2;
        }

        public string Message2 { get; set; }

    }
}
