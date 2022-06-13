using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharpPractice
{
    internal class Taple
    {
        public void Run()
        {
            var newPerson = CreatePerson();
        }
        public (int id, string fname, string lname) CreatePerson()
        {
            int id = 15;
            string fname = "Vlad";
            string lname =  "Probst";
            (int id, string fname, string lname) var1;
            var1.id = id;
            var1.fname = fname;
            var1.lname = lname;
            return var1;

        }
    }
}
