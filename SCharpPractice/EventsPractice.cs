using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharpPractice
{
   
    internal class EventsPractice
    {
        public delegate void TimeOut_func(int time);
        public event TimeOut_func TimeOut_handler;
        public void Run()
        {
            if (TimeOut_handler != null)
            {
                TimeOut_handler(1000);
            }
        }
    }

    public class Operate
    {
        EventsPractice EventsPractice = new EventsPractice();
        DB db = new DB();
        UI ui = new UI();
        public void init()
        {
            EventsPractice.TimeOut_handler += db.UpdateDataBaseAfterTimeOut;
            EventsPractice.TimeOut_handler += ui.UpdateUIAfterTimeOut;

            EventsPractice.Run();

            EventsPractice.TimeOut_handler -= ui.UpdateUIAfterTimeOut;
            EventsPractice.Run();
        }
    }

    public class DB
    {
        public void UpdateDataBaseAfterTimeOut(int time)
        {

        }

    }
    public class UI
    {
        public void UpdateUIAfterTimeOut(int time)
        {

        }
    }
}
