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
        //public override void Start()
        //{
        //    Console.WriteLine("changing in moto");
        //}

        public void TurnRight()
        {
            Console.WriteLine("moto is turning left ;)");
        }
    }
}

