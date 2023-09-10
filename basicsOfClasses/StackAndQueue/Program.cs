namespace StackAndQueue;

class Program
{
    static void Main(string[] args)
    {
        Stack myStack = new Stack();
        myStack.Push(12);
        myStack.Push(1);
        myStack.Push(24);
        myStack.Push(6);
        Console.WriteLine(myStack.isEmpty());
        Console.WriteLine(myStack.Pop()); 
        Console.WriteLine(myStack.Pop()); 
        Console.WriteLine(myStack.Peek());
        Console.WriteLine(myStack.Pop()); 
        Console.WriteLine(myStack.Pop()); 
        Console.WriteLine(myStack.isEmpty()); 

        Console.ReadKey();
    }
}

