using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharpPractice
{
    internal class MemoryStreamEaxmple
    {
        public void Run()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                byte[] buffer = new byte[100];

                buffer[0] = 12;
                buffer[1] = 13;
                buffer[2] = 23;
                buffer[3] = 98;

                ms.Write(buffer, 0, buffer.Length);
                ms.Seek(0, SeekOrigin.Begin);

                using (FileStream fs = new FileStream("output.txt", FileMode.CreateNew))
                {
                    ms.CopyTo(fs);
                    fs.Flush();
                }
            }
        }
    }
}
