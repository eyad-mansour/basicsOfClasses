namespace enumsTesting;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(UserType.visitor);
        Dictionary<string, int> doc = new Dictionary<string, int>();
        //array.Add(UserType.admin.ToString(), 2);
        
        foreach (UserType user in Enum.GetValues(typeof(UserType)))
        {
            doc.Add(user.ToString() ,(int)user);
        }
         
        doc.Add("sasa",121);
        foreach (var (key, value) in doc)
        {
            Console.WriteLine($"{key}:, {value}");
        }
        Console.ReadKey();
    }

    public void print(int value)
    {
        Console.WriteLine(value);
    }

    public enum UserType
    {
        admin=1,
        user=2,
        provider=3,
        visitor=4
    }

}

