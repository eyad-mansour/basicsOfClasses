using System;
namespace StackAndQueue.queue
{
    public class Queue
    {
        private Node Front;
        private Node Rear;

        public Queue()
        {
            Front = null;
            Rear = null;
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if(Front == null)
            {
                Front = Rear = newNode;
                return;
            }
            Rear.Next = newNode;
            Rear = newNode;
        }

        public int Dequeue()
        {
            int peek = -1;
            if (Front != null)
            {
                peek = Front.Data;
                Front = Front.Next;
            }
            return peek;
        }

        public int Peek()
        {
            if (Front != null)
            {
                return Front.Data;
            }
            return -1;
        }

        public bool IsEmpty()
        {
            if (Front ==null)
            {
                return true;
            }
            return false;
        }
    }
}

