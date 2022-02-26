using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAnalysis
{
    public class stack
    {
       public int size = 0;
       public  int top;
       public int[] arr;
    }
    public class StackUsingArray
    {
         public bool IsEmpty(stack ptr)
         {
            if(ptr.top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
         }

        public bool IsFull(stack ptr)
        {
            if(ptr.top == ptr.size-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Push(stack ptr,int val)
        {
            if(IsFull(ptr))
            {
                Console.WriteLine("Stack OverFlow");
                return;
            }
            else
            {
                ptr.top++;
                ptr.arr[ptr.top] = val;
                Console.WriteLine("Value Enterd SuccessFully in stack");
            }
        }

        public int Pop(stack ptr)
        {
            if(IsEmpty(ptr))
            {
                Console.WriteLine("Stack underflow");
                return -1;
            }
            else
            {
                
                int val = ptr.arr[ptr.top];
                ptr.top--;
                return val;
            }
        }
            
        public int Peek(stack ptr,int i)
        {
            int arrayInd = ptr.top - i + 1;
            if(arrayInd < 0)
            {
                Console.WriteLine("Invalid Position for stack ");
                return -1;
            }
            else
            {
                return ptr.arr[arrayInd];
            }
        }

        public void displayStack(stack ptr)
        {
            int i = 0;
            if(!IsEmpty(ptr))
            {
                while(i<ptr.size-1)
                {
                    Console.WriteLine("Element {0} ", ptr.arr[i]);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("stack is empty");
            }
        }

        public int StackTop(stack ptr)
        {
            return ptr.arr[ptr.top];
        }

        public int stackBottom(stack ptr)
        {
            return ptr.arr[0];
        }

            

            

    }
}
