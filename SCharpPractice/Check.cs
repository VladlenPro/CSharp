using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharpPractice
{
    internal class Check
    {
        public void Run()
        {
            try
            {
                checked
                {
                    byte a = 1;
                    a = byte.MaxValue - 2;
                    a++;
                    a++;
                    a++;
                    a++;
                    unchecked
                    {
                        a++;
                    }
                    a = byte.MaxValue;
                    a++;
                }
            }
            catch(OverflowException ex)
            {

            }
            
            int b = 2;

            for (int i = 0; i < int.MaxValue; i++)
            {
                b++;
            }
        }
    }
}
