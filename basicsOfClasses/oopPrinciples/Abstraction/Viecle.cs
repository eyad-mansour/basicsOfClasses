using System;
namespace oopPrinciples.Abstraction
{
    public abstract class Viecle
    {
        public abstract void Move();
        public abstract void Accelerate();
        public virtual void Brake()
        {
            Console.WriteLine("The viecle is braking");
        }
    }
}

