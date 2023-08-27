namespace static_memeber;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hello ");
        Console.ReadKey();
    }
}

public class Circle
{
    public static float pi = 3.14159f;
    public static int instances = 0;

    public float Radious { get; set; }

    public Circle(float radious)
    {
        this.Radious = radious;
        instances++;
    }

    public static float calculateArea(float radious)
    {
        return pi * radious * radious;
    }

}

