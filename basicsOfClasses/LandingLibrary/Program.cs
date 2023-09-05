namespace LandingLibrary;

class Program
{
    private static readonly Library library = new Library();
    private static readonly BookPack<Book> bookBag = new BookPack<Book>();
    static void Main(string[] args)
    {
        loadBook();
        UserIntrface();
        Console.ReadKey();
    }

    public static List<int> GetEvenNumber(int count)
    {
        var evenNumber = new List<int>();
        for (int i = 0; i < count; i++)
        {
            if (i % 2 == 0)
            {
                evenNumber.Add(i); 
            }
        }
        return evenNumber;
    }

    public static IEnumerable<int> GetEvenNumberWithYield(int count)
    {
        for (int i = 0; i < count; i++)
        {
            if(i % 2 == 0)
            {
                yield return i;
            }
        }
    }

    static void UserIntrface()
    {
        while (true)
        {
            Console.WriteLine("welcome to the lending library!");
            Console.WriteLine("pick an opetion...");
            Console.WriteLine("1. view all books");
            Console.WriteLine("2. add new book");
            Console.WriteLine("3. borrow a book");
            Console.WriteLine("4. return a book");
            Console.WriteLine("5. view book bag");
            Console.WriteLine("6. exit");

            string answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Library");
                    Console.WriteLine("=======");
                    OutPutBooks(library);
                    break;
                case "2":
                    Console.Clear();
                    AddBook();
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    BorrowBook();
                    break;
                case "4":
                    Console.Clear();
                    ReturnBook();
                    Console.Clear();
                    break;
                case "5":
                    Console.WriteLine("Book Bag");
                    OutPutBooks(bookBag);
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid Option");
                    Console.WriteLine();
                    break;
            }
        }
    }
    static void loadBook()
    {
        library.Add("Alice in wonderland", "lewis", "carol", 146);
        library.Add("the greate gatspy", "F. scott", "fitzgrlad", 156);
        library.Add("to kill the mockinbird", "harper", "lee", 343);
        library.Add("lord of the flies", "William", "Golding", 235);
    }

    static void OutPutBooks(IEnumerable<Book> books)
    {
        int counter = 1;
        foreach (Book book in books)
        {
            Console.WriteLine($"{counter++}: {book}");
        }
        Console.WriteLine();
    }
    private static void AddBook()
    {
        Console.WriteLine("please enter the following details:");
        Console.Write("Book title:");
        string title = Console.ReadLine();
        Console.Write("Author first name");
        Console.WriteLine();
        string firstName = Console.ReadLine();
        Console.Write("Author last name");
        string lastName = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Enter the number of pages");
        string numOfPages = Console.ReadLine();

        int.TryParse(numOfPages, out int result);

        library.Add(title, firstName, lastName, result);
    }

    private static void BorrowBook()
    {
        foreach (Book book in library)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine();
        Console.WriteLine("wich book would you like to borrow");
        string selection = Console.ReadLine();
        Book borrowed = library.Borrow(selection);
        bookBag.Pack(borrowed);
    }

    static void ReturnBook()
    {
        OutPutBooks(bookBag);
        Console.WriteLine("wich book would you like to return?");
        int selection = Convert.ToInt32(Console.ReadLine());
        Book bookToReturn = bookBag.Unpack(selection - 1);
        library.Return(bookToReturn);
    }

}

