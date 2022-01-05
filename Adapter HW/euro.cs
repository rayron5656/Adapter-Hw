using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_HW
{
    class euro : Ieuro
    {
        public double payment(int x)
        {
            return (x * 1.13);
        }
    }
}
