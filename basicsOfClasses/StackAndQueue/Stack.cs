using System;
namespace StackAndQueue
{
    public class Stack
    {
        private Node top;

        public Stack()
        {
            top = null;
        }

        public bool isEmpty()
        {
            return top == null;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }
        public int Pop()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("stack is empty");
            }
            int data = top.Data;
            top = top.Next;
            return data;
        }
        public int Peek()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("stack is empty");
            }
            return top.Data;
        }
    }
}

