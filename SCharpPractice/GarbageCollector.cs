using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharpPractice
{
    internal class GarbageCollector
    {
        public event Action EventHandler;

        public void Run()
        {
            Stack<Car> cars = new Stack<Car>();
            for(int i = 0; i < 100000; i++)
            {
                Car car = new Car();
                cars.Push(new Car());
            }

            GC.Collect();
            //This will create memoryleak
            //for (int i = 0; i < 1000; i++)
            //{
            //    Screen screen = new Screen();
            //    EventHandler += screen.Run;
            //}
           
        }

        public class CarPool
        {
            private Stack<Car> cars = new Stack<Car>();
            public CarPool()
            {
                for (int i = 0; i < 100; i++)
                {
                    cars.Push(new Car());
                }
            }
            public Car Allocate()
            {
                return null;
            }

            public void Free(Car car)
            {
                
            }
        }

        public class Screen
        {
            public void Run()
            {

            }
        }
    }
}
