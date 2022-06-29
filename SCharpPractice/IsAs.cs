using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharpPractice
{
    class aaa
    {

    }
    class bbb
    {

    }

    class ccc: aaa
    {
        public void Run_ccc()
        {

        }
    }
    internal class IsAs
    {
        public void Run()
        {
            aaa a = new aaa();
            bbb b = new bbb();
            ccc c = new ccc();
            Opeate(c);
        }

        public void Opeate(object o)
        {
            bool test = o is aaa;
            test = o is bbb;
            test = o is ccc;
            test = o is object;
            test = o is System.IO.FileStream;

            if(o is ccc)
            {
                ccc c = o as ccc;
                c.Run_ccc();
            }
        }
    }
}
