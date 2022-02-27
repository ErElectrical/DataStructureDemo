using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  QueueAnalysisUsingLinkedList

{
    public class Node
    {
        public int data;
        public Node Next;
        public Node(int data)
        {
            this.data = data;
            Next = null;
        }
    }
    public class QueueLinkedList
    {

        Node front = null;
        Node rear = null;


        public bool IsFull(Node ptr)
        {
            if(ptr==null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool IsEmpty()
        {
           if(front==rear)
           {
               return true;
           }
            else
            {
               return false;
           }
        }

        public void Enqueue(int val)
        {
            Node new_Node = new Node(val);
            if(IsFull(new_Node))
            {
                Console.WriteLine("Queue is Full");
            }
            else
            {
                Console.WriteLine("Data insert to Queue is : {0} ", val);
                new_Node.Next = null;
                if(front == null)
                {
                    front = rear = new_Node;
                }
                else
                {
                    rear.Next = new_Node;
                    rear = new_Node;
                }
            }

        }

        public int dequeue()
        {
            int val = -1;
            Node temp = front;
            if(front == null)
            {
                Console.WriteLine("Queue is Empty");
                return val;
            }
            else
            {
                front = front.Next;
                val = temp.data;
                temp = temp.Next;

            }
            return val;
        }

        public void QueueTraversal()
        {
            Console.WriteLine("printing the element of the Queue");
            while(front!= null)
            {
                Console.WriteLine("Element : {0} ", front.data);
                front = front.Next;
            }
        }
    }
}
