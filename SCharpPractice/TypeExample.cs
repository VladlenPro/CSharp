using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharpPractice
{
    class a { }
    class b:a 
    {
        public int MyProperty { get; set; }
        public string MyPropert1 { get; set; }
    }
    internal class TypeExample
    {
        FileStream fs;

        public void Run1()
        {
            a a= new a();
            b b= new b();
            b.MyProperty = 1;
            b.MyPropert1 = "2";
            object o = b;
            GetObject(b);
            GetObject(o);
            GetObject(1);
            GetObject("2");
        }

        public void GetObject(object o)
        {
            Type type = o.GetType();
        }
        public void Run()
        {
            try
            {
                fs = System.IO.File.OpenRead("");
            }finally
            {
                fs.Close();
            }

            //for (int i = 0; i < 100; i++)
            //{
            //    TypeExample typeExample = new TypeExample();
            //}
        }

        public TypeExample()
        {
            //constructor
        }

        ~TypeExample()
        {
            //destractor
            //finalizer
            fs.Close();
        }
    }
}
