using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentheisAnalysis
{
    
        public class stack
        {
            public int size = 0;
            public int top;
            public char[] arr;
        }
        public class StackUsingArray
        {
            public bool IsEmpty(stack ptr)
            {
                if (ptr.top == -1)
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
                if (ptr.top == ptr.size - 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Push(stack ptr, char val)
            {
                if (IsFull(ptr))
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

            public char Pop(stack ptr)
            {
                if (IsEmpty(ptr))
                {
                    Console.WriteLine("Stack underflow");
                    return ' ';
                }
                else
                {

                    char val = ptr.arr[ptr.top];
                    ptr.top--;
                    return val;
                }
            }

            

            public void displayStack(stack ptr)
            {
                int i = 0;
                if (!IsEmpty(ptr))
                {
                    while (i < ptr.size - 1)
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

            /// <summary>
            /// Parenthesis is Correct only if we get An Empty stack after completion of Opreation.
            /// for opening Parentheis ( we push data into Stack
            /// for closing parentheis ) we pop data from the stack.
            /// at last we check weather our stack is empty or not
            /// if we found that stack is not empty than Parenthesis are not correct
            /// otherwise it is correct.
            /// </summary>
            /// <param name="ptr"></param>
            /// <param name="input"></param>
            public void ParenthesisMatch(stack ptr,char[] input)    
            {
                ptr.size = 100;
                ptr.top = -1;
                ptr.arr = new char[ptr.size];

                for(int i=0;i<input.Length;i++)
                {
                    if(input[i] == '(')
                    {
                        Push(ptr,input[i]);
                    }
                    else if(input[i] == ')')
                    {
                        Pop(ptr);
                    }
                }
                if(IsEmpty(ptr))
                {
                    Console.WriteLine("Parentheis  Match completley");
                    
                }
                else
                {
                    Console.WriteLine("parentheis Not Match completley");
                    
                }

            }
            
        public void MultipleParentheisMatching(stack ptr,char[] input)
        {
            ptr.size = input.Length;
            ptr.top = -1;
            ptr.arr = new char[ptr.size];
            char popped_char =' ';
            for(int i=0; i<input.Length;i++)
            {
                if(input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                    Push(ptr, input[i]);
                }
                else if(input[i] == ')' || input[i] == '}' || input[i] == ']' )
                {
                    if(IsEmpty(ptr))
                    {
                        return;
                    }
                    popped_char = Pop(ptr);

                    if(!Match(popped_char,input[i]))
                    {
                        Console.WriteLine("Parenthesis not balanced ");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Parenthesis balanced");
                    }

                }
            }
        }

        private bool Match(char a,char b)
        {
            if(a=='(' && b == ')')
            {
                return true;
            }
            if(a=='{' && b=='}')
            {
                return true;
            }
            if(a == '[' && b == ']')
            {
                return true;
            }
            return false;
        }
            





        }
    }

