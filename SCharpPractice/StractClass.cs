using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharpPractice
{
    internal class StractClass
    {
        int a;
        public void Run()
        {
            RealStructClass stru;
            stru.a = 123;
            stru.b = 224;
            stru.Run();
        }
    }

    struct RealStructClass
    {
        public int a;
        public int b;
        public int Run()
        {
            return 12;
        }
    }
}
