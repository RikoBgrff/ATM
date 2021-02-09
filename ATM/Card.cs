using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Card
    {
        public string PAN { get; set; } = PanGenerator.GeneratePan();
        public string PIN { get; set; }
        public string CVC { get; set; }
        public string ExpireDate { get; set; }
        public decimal Balance { get; set; }
    }
}
