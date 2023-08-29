using System;
namespace oopPrinciples.Inheritance
{
    public class Motorcycle : Veicle
    {
        
        public bool HasSideCar { get; set; }

        public void Wheelie()
        {
            Console.WriteLine("the motor can is on the wheelie");
        }

        public void TurnRight()
        {
            Console.WriteLine("moto is turning left ;)");
        }
    }
}

