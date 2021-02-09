using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class OutOfBalance :ApplicationException
    {
        public OutOfBalance(string message)
        {
            Message1 = message;
        }

        public string Message1 { get; set; }

    }
}
