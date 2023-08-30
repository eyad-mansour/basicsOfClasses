using System;
namespace oopPrinciples.Inheritance
{
    public class Veicle
    {
        public string Make { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("veicle is starting...");
        }

        public void Stop()
        {
            Console.WriteLine("veicle is stopping...");
        }

        public int GetYear()
        {
            return Year;
        }

        public virtual void TurnLeft()
        {
            Console.WriteLine("veicle is turning right ;)");
        }

    }
}

