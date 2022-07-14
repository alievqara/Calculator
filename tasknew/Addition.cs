using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasknew
{
    public sealed class Addition : Calculation
    {

        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public override int Operate(int x, int y)
        {
            this.FirstNumber = x;
            this.SecondNumber = y;  
            //Console.WriteLine($"First Number:{x}, Second Number:{y}, Result:{x + y}");
            return x + y;
        }
    }
}
