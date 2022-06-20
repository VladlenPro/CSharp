using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharpPractice
{
    internal class RefVal
    {
        public void Run()
        {
            Label l = new Label();
            l.Text = "456";
            ChangeLabel(l);
            int a = 10;
            int b;
            Change(a);
        }
        public int Change(int a)
        {
            a++;
            return a * a;
        }
        public int ChangeLabel(Label l)
        {
            l.Text = "123";
            return 10;
        }

        public void Val()
        {
            int a;

            int? b;

            b = null;

            if (b == null)
            {

            }

            if (b is null)
            {

            }
            if(b.HasValue)
            {

            }


            Label l = null;
            if(l !=null)
            {
                l = new Label();
            }

        }
    }
}
