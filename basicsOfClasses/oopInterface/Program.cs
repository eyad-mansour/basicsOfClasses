using oopInterface.Classes;

namespace oopInterface;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Developer meh = new Developer() { Age= 12, Name="mohammad", Salaray=500 };
        DelevaryDriver driver = new DelevaryDriver() { Age = 40, Name="khalid", Licence= "234i52592***asd232**"};


        ValidateDriver(driver);
        Console.WriteLine(meh.Salaray);

        Console.ReadKey();
    }
    public static void ValidateDriver(IDrive driver)
    {
        Console.WriteLine($"driver licence : {driver.Licence}");
        Console.WriteLine($"i adjust the veichel {driver.AdjustSetteing()}");
    }

}

