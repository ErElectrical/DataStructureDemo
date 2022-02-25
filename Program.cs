using System;

namespace StackAnalysis
{
    public class  Program
    {
        static void Main()
        {
            stack s= new stack();
            s.size = 80;
            s.top = -1;
            s.arr = new int[s.size];

         

            StackUsingArray sa = new StackUsingArray();
            //if(sa.IsEmpty(s))
            //{
            //    Console.WriteLine("Stack is Empty ");
            //}
            //else
            //{
            //    Console.WriteLine("Stack is not Empty");
            //}

            sa.Push(s, 12);
            sa.Push(s, 23);
            //int val = sa.Pop(s);
            //Console.WriteLine( val);

            int val=sa.Peek(s, 2);
            Console.WriteLine(val);

        }
    }
}