using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharpPractice
{
    internal class Delegate
    {
        public delegate int  CalcFunc(int x, int y);

        public void Run()
        {
            CalcFunc f = Calc1;
            f = Calc2;
            int r = f(4, 4);
            CalcTax(200, Calc1);
            CalcTax(200, Calc2);
            CalcTax(200, Calc3);
            CalcTax(200, Calc4);
        }

        public int CalcTax (int price, CalcFunc func)
        {
            return func(price, 20);
        }

        public int Calc1(int x, int y)
        {
            return x * y;
        }

        public int Calc2(int x, int y)
        {
            return x / y;
        }
        public int Calc3(int x, int y)
        {
            return x - y;
        }
        public int Calc4(int x, int y)
        {
            return x + y;
        }
    }
}
