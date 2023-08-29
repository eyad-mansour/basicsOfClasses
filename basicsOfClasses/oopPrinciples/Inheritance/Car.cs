using System;
namespace oopPrinciples.Inheritance
{
    public class Car : Veicle
    {
        public int NumOfDoor { get; set; }


        public void Accelerate()
        {
            Console.WriteLine("accelerate the car...");
        }

        public void Brake()
        {
            Console.WriteLine("brake the car..");
        }

        public int GetYear()
        {
            return Year;
        }
    }
}

