using System;
namespace oopPrinciples.Abstraction
{
    public class Car : Viecle
    {
        public string Name { get; set; } = "kia";

        public override void Move()
        {
            Console.WriteLine("the car is moving");
        }
        public override void Accelerate()
        {
            Console.WriteLine("the car is accelerting");
        }
        public override void Brake()
        {
            Console.WriteLine("the car is braking");
        }
    }
}

