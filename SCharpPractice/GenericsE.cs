using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharpPractice
{
    internal class GenericsE
    {
        public void Run()
        {
            List<string> list = new List<string>();
            list.Add("123456789");

            List<int> list1 = new List<int>();
            list1.Add(1);

            var p = new Point(100, 300);

            string s = func<Point, string>(p, "this is my point");

            //Sample<myStruct> sample = new Sample<myStruct>();
            //Sample<List<int>,int> sample = new Sample<List<int>, int>();
            Sample<b> sample2 = new Sample<b>();
            //Sample<c> sample3 = new Sample<c>();

            //sample.SetItem(new Point(100, 300));
        }

        public class PrintManager<T>
        {

        }

        //public class Sample<T,Z> where T : IEnumerable<Z>
        public class Sample<T> where T: a, new()
        {
            public void SetItem(T item)
            {

            }
        }
        struct myStruct
        {
            int a;
            int b;
            int c;
        }

        public string func<T, Z>(T o, Z y)
        {
            string s = o.ToString() + " " + y.ToString();
            return s;
        }

        public class a 
        {
        }
        public class b: a { }
        public class c :a { }
    }
}
