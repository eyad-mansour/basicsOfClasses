using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassesAndObjects.Classes
{
    internal class Car
    {

        private Engine engine;

        /*
          Properties

            GET (accessor) - is used to return the property value
            SET (setter)- is used to assign a new value.
            Props can be read/write (have both a getter and a setter), 
            if only a get it's readonly.
            if only a set, its write only (less common/rare) used to restrict access to sensitive data. 

            Auto Implemented Properties:
            { get; set; }

            With auto implements properties, a backing field is created anyway...
            we just don't see it. This can be used to an advantage of not having 
            to worry about extra floating variables. 

            If we plan on having logic in our properties, we must create our own backing stores. 
            Auto implemented properties are not good options for these types of properties. 

        */
        public string Make { get; set; }
        public int weelNum { get; set; }
        public bool IsDriving { get; set; }
        public int Speed { get; set; }
        public Engine DriveTrain { get; set; }
        public int MyProperty { get; set; }

        public Car()
        {
                    
        }


        /*

          Once upon a time, "backing fields" were a thing. 
          this is before we had auto implemented properties. 
          backing fields are private variables to the class that 
          would assist in the constructor of a property. 

          This method of setting properties is very "old school" 
          and is not used very much anymore. we primarily depend on 
          auto implemented properties now instead of depending on a backing store. 

        */

        private string carColor;
        internal string Color
        {
            get { return carColor; }
            set
            {
                // Nobody makes brown cars anymore ...
                if (value == "brown")
                {
                    carColor = "Red";
                }
                else
                {
                    carColor = value;
                }
            }
        }
        private int nnn;
        public int  getNnnn()
        {
            return this.nnn;
        }
        public void setNnnn(int value)
        {
           this.nnn = value;
        }
        // Empty / Default Constructor
        // Car myCar = new Car();

        // Overloaded Constructor, that takes arguments
        // Car myCar = new Car("mazda", "grey", 4);
        internal Car(string make, string color, int cyl)
        {
            Console.WriteLine("I am in the overloaded constructor...");
            Make = make;
            Color = color;
            DriveTrain = new Engine(cyl);
        }

        // It's good practice to create methods for your classes that change
        // the instance properties rather than let developers directly manipulate
        // them. This puts the class author in control
        internal void Drive()
        {
            IsDriving = true;
        }

        internal void Stop()
        {
            IsDriving = false;
        }

        internal void print()
        {
            Console.WriteLine(Make, weelNum, Color, carColor);
        }

    }

    


}