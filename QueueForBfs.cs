using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDataStructureAnalysis
{
    public class Queue
    {
        public int size;
        public int front;
        public int rear;
        public int[] arr;


    }
    public class QueueImplementationonArray
    {
        public void enqueue(Queue ptr, int val)
        {
            if (IsFull(ptr))
            {
                Console.WriteLine("Queue is Full ");
            }
            else
            {
                ptr.rear++;
                ptr.arr[ptr.rear] = val;
            }
        }

        public int dequeue(Queue ptr)
        {
            int val = -1;
            if (IsEmpty(ptr))
            {
                Console.WriteLine("Queue is Empty nothing to dequeue");
                return val;
            }
            else
            {
                ptr.front++;
                val = ptr.arr[ptr.front];
                return val;
            }
        }

        public bool IsFull(Queue ptr)
        {
            if (ptr.rear == ptr.size - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsEmpty(Queue ptr)
        {
            if (ptr.front == ptr.rear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void QueueTraversal(Queue ptr)
        {
            if (IsEmpty(ptr))
            {
                Console.WriteLine("queue is Empty nothing to display");
                return;
            }
            else
            {
                int i = 0;
                while (i < ptr.arr.Length)
                {
                    Console.WriteLine("Element : {0} ", ptr.arr[i]);
                    i++;
                    if (ptr.arr[i] == 0)
                    {
                        break;
                    }
                }
            }
        }
    }
}
