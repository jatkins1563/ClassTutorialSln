using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTutorial
{
    class TqlMath
    {
        public TqlMath(int a, int B)
        {
            A = a;
            this.B = B;
        }
        public int A { get; set; }
        public int B { get; set; }

        public int Sum()
        {
            return A + B;
        }
        public int Diff()
        {
            return A - B;
        }
    }
}
