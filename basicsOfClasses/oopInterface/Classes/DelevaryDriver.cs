using System;
using oopInterface.interfaces;
namespace oopInterface.Classes
{
    public class DelevaryDriver : Person, IDrive
    {
        public override string Name { get; set; }
        public override int Age { get; set; }
        public string Licence { get; set; }

        public string AdjustSetteing()
        {
            return "my miror and seat is adjusted";
        }

        public string Deliver(IDriveable veicle)
        {
            veicle.Start();
            veicle.Steer();
            veicle.Accelerate();
            veicle.Decelerate();
            veicle.Stop();

            return "pakage was deliverd";
        } 

    }
}

