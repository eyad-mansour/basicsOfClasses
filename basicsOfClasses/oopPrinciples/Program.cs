namespace oopPrinciples;
//using Abstraction;
using Polymorphism;
using Encapsulation;
using Inheritance;
internal class Program
{
    static void Main(string[] args)
    {
        //abstraction
        //Viecle toyota = new Car();
        //toyota.Brake();
        //toyota.Accelerate();
        //toyota.Move();

        // polymorphism
        //List<Shape> shapes = new List<Shape>();
        //shapes.Add(new Circle());
        //shapes.Add(new Square());
        //shapes.Add(new Circle());
        //shapes.Add(new Shape());

        //foreach (Shape item in shapes)
        //{
        //    item.Draw();
        //}

        //Encapsulation
        //BankAccount saleem_fhim = new BankAccount("1111", 3244, "saleem abu abd al abd");
        //saleem_fhim.Deposit(1200);
        //Console.WriteLine(saleem_fhim.GetBalance());
        //saleem_fhim.Withdrew(1000);
        //Console.WriteLine(saleem_fhim.GetBalance());

        //Inheritance

        Veicle alto = new Car();
        Veicle GSX = new Motorcycle();
        Veicle wrangler = new Veicle();

        wrangler.Color = "black";
        GSX.Make = "suzuki";
        GSX.TurnLeft();

        GSX.Start();
        alto.Color = "blue";
        alto.TurnLeft();

        if(GSX is Motorcycle motorcycleInstance)
            {
            motorcycleInstance.TurnRight();
        }
        ((Motorcycle)(GSX)).TurnRight();
        
        
        GSX.Start();
        //GSX.Stop();


        alto.Year = 2020;
        Console.WriteLine(alto.GetYear()); 
        Console.WriteLine(wrangler.Color);
        Console.WriteLine(alto.Color +" saleeeem");
        Console.ReadKey();
    }
}

