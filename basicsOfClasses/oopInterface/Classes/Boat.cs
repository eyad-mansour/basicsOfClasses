using System;
using oopInterface.interfaces;
namespace oopInterface.Classes
{
    public class Boat : IDriveable
    {
        public string BoatNme{ get; set; }
        public void Start()
        {
            Console.WriteLine("the boat is starting");
        }
        public void Steer()
        {
            Console.WriteLine("the boat is steering");
        }
        public void Accelerate()
        {
            Console.WriteLine("the boat is accelerating");
        }
        public void Decelerate()
        {
            Console.WriteLine("the boat is stopping");
        }
        public void Stop()
        {
            Console.WriteLine("the boat stopped");
        }
    }
}

