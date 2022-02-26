using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAnalysis
{
    public class Node
    {
        public int data;
        public Node Next;

        public Node()
        {
            data = 0;
            Next = null;
        }
        public Node(int data)
        {
            this.data = data;
            Next = null;
        }
    }
    public class StackUsingLinkedList
    {
        public Node top;
        public StackUsingLinkedList()
        {
            this.top = null;
        }
        
        public bool IsFull()
        {
            Node ptr = new Node();
            if(ptr == null)
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
            if( top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void  Push( int x)
        {
            Node new_node = new Node(x);

            if (!IsFull())
            {
               
                new_node.Next = top;
                top = new_node;
                Console.WriteLine("{0} pushed to stack",x);
               



            }
            else if(top == null)
            {
                new_node.Next = null;
            }
            else
            {
                Console.WriteLine("Stack OverFlow");
             
            }
           
           
        }

        public int Pop()
        {
            int pop = -1;
            if(IsEmpty())
            {
                Console.WriteLine("Stack underflow Deletion not Possible");
                return pop;
                
            }
            else
            {
                pop = top.data;
                top = top.Next;
                return pop;
               
            }
        }

        public void Peek()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack UnderFlow Peek Not possible");
            }
            else
            {
                Console.WriteLine("{0} is on the top of the stack ", top.data);
            }
        }

        public int Peek(int pos)
        {
            Node new_node = top;
            for(int i = 0; (i<pos-1&&new_node != null) ; i++)
            {
                new_node = new_node.Next;
            }
            if(new_node != null)
            {
                return new_node.data;
            }
            else
            {
                return -1;
            }
        }

        public void StackTop()
        {
            Console.WriteLine("{0} value on top of stack ", top.data);
        }
        public void StackBottom()
        {
            Node temp = top;
            while(temp.Next != null)
            {
                temp = temp.Next;
            }
            Console.WriteLine("{0} value of bottom ", temp.data);
        }
        public void StackTraversal()
        {
            if (!IsEmpty())
            {
                while (top != null)
                {
                    Console.WriteLine($"Element : {top.data} ");
                    top = top.Next;
                }
            }
            else
            {
                Console.WriteLine("Stack is Empty ");
            }
        }
    }
}
