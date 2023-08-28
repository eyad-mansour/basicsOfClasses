namespace linkedList;

class Program
{
    static void Main(string[] args)
    {
        LinkedList myList = new LinkedList();
        myList.Add(12);
        myList.Add(15);
        myList.Add(16);
        myList.Add(11);

        myList.addAt(12,3);

        myList.deleteN(1);
        myList.deleteN(2);
        myList.deleteN(3);
        myList.deleteN(4);

        try
        {
            Node current = myList.Head;
            while (current.Data != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }

        Console.ReadKey();
    }
}

public class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node (int data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList
{
    public Node Head { get; set; }
    public Node Tail { get; set; }

    public LinkedList()
    {
        Node Head = null;
        Node Tail = null;
    }

    public void Add(int data)
    {
        Node newNode = new Node(data);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            Tail = newNode;
        }
    }

    public void addAt(int data, int position)
    {
        Node newNode = new Node(data);
        Node prevNode = null;
        Node currentNode = Head;
        int currentPosition = 0;

        while (currentNode != null && currentPosition < position)
        {
            prevNode = currentNode;
            currentNode = currentNode.Next;
            currentPosition++;
        }
        if(currentPosition == position)
        {
            prevNode.Next = newNode;
            newNode.Next = currentNode;
            if(currentNode == null)
            {
                Tail = newNode;
            }
        }
        else
        {
            Console.WriteLine($"the position is out of Ranege {position}");
        }
    }

    public void deleteN(int position)
    {
        Node currentNode = Head;
        int currentPosition = 0;

        while (currentNode != null && currentPosition < position)
        {
            currentNode = currentNode.Next;
            currentPosition++;
        }
        if (currentPosition == position)
        {
            try
            {
                currentNode = currentNode.Next.Next;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
        else
        {
            Console.WriteLine($"the position is out of Ranege {position}");
        }

    } 


}

