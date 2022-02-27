using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAnalysis
{
    /// <summary>
    /// Problem with simple queue is that once the front crosses any index we can not use that place further
    /// even that place is empty after dequeue opreation still we can not able to use that place because 
    /// enqueue always occur at rear side .
    /// if length of our array is suppose 4 and we do first 4 enqueue opreation 
    /// and after that we do 4 dequeue opreation 
    /// now technically our queue is empty but it will show queue is full
    /// because both front and rear pointer indexes are at same place.
    /// </summary>
    public class Queue
    {
        public int size;
        public int front;
        public int rear;
        public int[] arr;


    }
    public class QueueImplementationonArray
    {
        public void enqueue(Queue ptr,int val)
        {
            if(IsFull(ptr))
            {
                Console.WriteLine("Queue is Full ");
            }
            else
            {
                ptr.rear++;
                ptr.arr[ptr.rear] = val;
                Console.WriteLine("Element inserted is : {0}", val);
            }
        }

        public int dequeue(Queue ptr)
        {
            int val = -1;
            if(IsEmpty(ptr))
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
            if(ptr.rear == ptr.size-1)
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
            if(ptr.front ==ptr.rear)
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
            if(IsEmpty(ptr))
            {
                Console.WriteLine("queue is Empty nothing to display");
                return;
            }
            else
            {
                int i = 0;
                while(i<ptr.arr.Length)
                {
                    Console.WriteLine("Element : {0} ", ptr.arr[i]);
                    i++;
                    
                }
            }
        }
    }
}
