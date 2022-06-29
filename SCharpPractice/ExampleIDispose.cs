using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharpPractice
{
    class MakeBigRequest : IDisposable
    {
        public void Dispose()
        {
            Release();
        }

        public void Operate()
        {

        }

        public void Release()
        {

        }
    }
    internal class ExampleIDispose
    {
        public void Run()
        {
            //MakeBigRequest makeBigRequest = new MakeBigRequest();
            //makeBigRequest.Operate();
            //release resourses
            //makeBigRequest.Release();
            //or
            //makeBigRequest.Dispose();
            using (MakeBigRequest makeBigRequest = new MakeBigRequest())
            {
                makeBigRequest.Operate();
            }
            //using (var f = System.IO.File.Open())
            //{

            //}
        }
    }
}
