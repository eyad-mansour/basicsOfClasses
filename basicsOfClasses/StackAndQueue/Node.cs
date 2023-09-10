using System;
namespace StackAndQueue
{
    public class Node
    {
        public int Data { set; get; }
        public Node Next {set; get;}
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
}

