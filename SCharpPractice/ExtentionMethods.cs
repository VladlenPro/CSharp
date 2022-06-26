using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharpPractice
{
    public class Utilities
    {
        public static int DotsCounter(string str)
        {
            return str.Split('.').Count() - 1;
        }

    }

    public static class ExtStringMethod
    {
        public static int DotsCounter(this string str)
        {
            return str.Split('.').Count() - 1;
        }

        public static  bool HasMobily(this Car car, int year)
        {
            if(year>=2022)
            {
                return true;
            }
            if(car.GetPrice()>9000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    internal class ExtentionMethods
    {
        public void Run()
        {
            string s = "absd and. something. more";
            int a = s.DotsCounter();
            a = Utilities.DotsCounter(s);

            Car car = new Car();

            car.HasMobily(2022);
        }

        public int DotsCounter(string str)
        {
            return str.Split('.').Count()-1;
        }
    }

    public class Car
    {
        public int GetPrice()
        {
            return 100000;
        }
    }
}
