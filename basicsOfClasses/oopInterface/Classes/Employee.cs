using System;
namespace oopInterface.Classes
{
    public abstract class Employee : Person
    {
        public override string Name { get; set; }
        public override int Age { get; set; }

        public abstract int Salaray { get; set; }
    }
}

