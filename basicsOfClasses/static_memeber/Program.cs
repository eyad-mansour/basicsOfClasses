namespace static_memeber;

class Program
{
    static void Main(string[] args)
    {
        Circle small = new Circle(3);
        Circle big = new Circle(8);


        Console.ReadKey();
    }
}

public class Circle
{
    public static float pi = 3.14159f;
    public static int instances = 0;

    public float Radious { get; set; }

    public static void print()
    {
        Console.WriteLine("");
    }

    public Circle(float radious )
    {
        this.Radious = radious;
        instances++;
    }

    public static float calculateArea(float radious)
    {
        return pi * radious * radious;
    }

}

