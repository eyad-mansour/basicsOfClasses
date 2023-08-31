using System;
using oopInterface.interfaces;

namespace oopInterface.Classes
{
    public class Robot : IDrive, IDriveable
    {
        public string Licence { set; get; }
        public string AdjustSetteing()
        {
            return "setting is adjust i am a robot";
        }

        public void Start()
        {
            Console.WriteLine("i am starting");
        }
        public void Steer()
        {
            Console.WriteLine("i am steering");
        }
        public void Accelerate()
        {
            Console.WriteLine("i am accelerating");
        }
        public void Decelerate()
        {
            Console.WriteLine("i am accelerating");
        }
        public void Stop()
        {
            Console.WriteLine("i am stoping");
        }

    }
}

