using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class PanGenerator
    {
        public static string GeneratePan()
        {
            string a = null;
            Random rd = new Random();
            int rand_num = rd.Next(1001, 9999);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                rand_num = rd.Next(1001, 9999);
                a = builder.Append(rand_num).ToString();
            }
            return a;
        }
        public string PAN { get; set; } = GeneratePan();

    }
}
