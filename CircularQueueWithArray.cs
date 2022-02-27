using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAnalysis
{
    /// <summary>
    /// To solve the drawbck of simple queue we design circular queue 
    /// in simple queue we do linear increment of front and rear
    /// but here we have to do circular increment 
    /// in circular queue both front and raer start at 0
    /// where in simple queue both front and rear start at -1
    /// one place is always empty in circular queue that differntiate between front and rear.
    /// </summary>
    public class CircularQueue
    {
        public int size;
        public int front;
        public int rear;
        public int[] arr;
    }
    public class CircularQueueWithArray
    {
        public bool IsEmpty(CircularQueue ptr)
        {
            if(ptr.front == ptr.rear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull(CircularQueue ptr)
        {
            if((ptr.rear+1)%ptr.size == ptr.front)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void enqueue(CircularQueue ptr,int val)
        {
            if(IsFull(ptr))
            {
                Console.WriteLine("Circular Queue is full can not insert");
                return;
            }
            else
            {
                ptr.rear = (ptr.rear + 1) % ptr.size;
                ptr.arr[ptr.rear] = val;
                Console.WriteLine("Insertion Occur Successfully Element is {0} ",val);
            }
                

            
        }

        public int dequeue(CircularQueue ptr)
        {
            int val = -1;
            if(IsEmpty(ptr))
            {
                Console.WriteLine("circular queue is Empty can not do futher deletion");
                return val;
            }
            else
            {
                ptr.front = (ptr.front + 1) % ptr.size;
                val = ptr.arr[ptr.front];
                return val;
            }
        }

        public void QueueTraversal(CircularQueue ptr)
        {
            if (IsEmpty(ptr))
            {
                Console.WriteLine("Circularqueue is Empty nothing to display");
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
