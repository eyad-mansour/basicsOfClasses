namespace StackAndQueue;
using StackAndQueue.queue;
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

        Queue myQueue = new Queue();
        myQueue.Enqueue(12);
        myQueue.Enqueue(1);
        myQueue.Enqueue(15);
        myQueue.Enqueue(9);
        Console.WriteLine(myQueue.Peek());
        myQueue.Dequeue();
        Console.WriteLine(myQueue.Peek());
        Console.WriteLine(myQueue.IsEmpty());
        myQueue.Dequeue();
        myQueue.Dequeue();
        myQueue.Dequeue();
        Console.WriteLine(myQueue.IsEmpty());
        Console.ReadKey();
    }
}

