using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasknew
{
    public sealed class Multiplication : Calculation
    {
      
        public override int Operate(int x, int y)
        {

            return x * y;
        }
    }
}
