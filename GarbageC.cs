using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Concepts
{
    internal class GarbageC
    {
        public event Action EventHandler ;
        Stack<Car> cars = new Stack<Car>();
        public void Run()
        {
            for (int i = 0; i < 10000; i++)
            {
                Car car = new Car();
                cars.Push(new Car());
                //memory allocation
                //free memory

                //disadvantages
                //defregmentation
                //freeze threads

                //release huge memory:
                //run the GC free memory process
                GC.Collect();
            }
                //memory leaks
                for (int i = 0; i < 1000; i++)
                {
                    Screen screen = new Screen();
                    EventHandler += screen.Run;
                }
                
            

        }

     
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
    public class Car
    {
        public string Name { get; set; }
    }
}
public class Screen
{
    public void Run()
    {

    }
}