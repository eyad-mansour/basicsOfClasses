using ClassesAndObjects.Classes;

namespace basicsOfClasses;

 internal class Program
{
    static void Main(string[] args)
    {
        Car sonata = new Car();
        sonata.Stop();
        sonata.weelNum = 34;
        sonata.
        sonata.getNnnn();
        sonata.Make = "toyota";
        sonata.Stop();
        Console.WriteLine(sonata.Make);
        User mohammad = new User();
        mohammad.gender = "male";
        //Console.WriteLine(mohammad.gender);
        //Console.WriteLine(mohammad.name);
        //Console.WriteLine(mohammad.birthYear);
      User.age();

        User khalid = new User();
        Console.WriteLine(logging.changeUser());
        Console.ReadKey();
        
    }
    
}
    internal class User
    {
            public string name;
            public string gender;
            public int birthYear;

            internal static int age()
            {
                return 6;
            }
   }
internal class logging
{
    internal string name;
    internal string gender;
    internal int birthYear;

    internal static int changeUser()
    {
        return 6;
    }
}
