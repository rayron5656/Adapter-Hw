using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_HW
{
    public class Dollar : IDollar
    {
        public double paymnet(int x)
        {
            return x;

        }
    }
}
