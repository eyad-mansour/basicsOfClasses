using System;
namespace oopInterface.Classes
{
    public class Developer : Employee
    {
        public override int Salaray { get; set; }

        public void Print ()
        {
            Console.WriteLine($"{Name} is a Developer and his salary is  {Salaray} and his age is {Age}");
        }
    }
}

