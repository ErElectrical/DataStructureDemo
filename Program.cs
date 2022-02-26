using System;

namespace StackAnalysis
{
    public class  Program
    {
        /// <summary>
        /// A Stack is a linear data structure which allows adding and removing of elements in a particular order.
        /// New elements are added at the top of Stack.
        /// If we want to remove an element from the Stack, we can only remove the top element from Stack.
        /// Since it allows insertion and deletion from only one end and the element to be inserted last will be the element to be deleted first,
        /// hence it is called Last in First Out data structure (LIFO). 
        /// Uses
        /// Stack can be used to implement back/forward button in the browser.
        
        ///Undo feature in the text editors are also implemented using Stack.
        ///It is also used to implement recursion.
        ///Call and return mechanism for a method uses Stack.
        ///It is also used to implement backtracking.


        /// </summary>
    static void Main()
        {
            Console.WriteLine("Choose which Stack You want " +
                                "\n1. with Array" +
                                "\n2. With LinkedList");
            int val = Convert.ToInt32(Console.ReadLine());
            bool StackArrayflag = true;
            bool stackLinkedlistflag = true;
            if (val == 1)
            {
                stack s = new stack();
                s.top = -1;
                Console.WriteLine("Enter size of your array ");
                int size = Convert.ToInt32(Console.ReadLine());
                s.size = size;
                s.arr = new int[s.size];
                while (StackArrayflag == true)
                {


                    Console.WriteLine("choose Wisely for Opreation on stack" +
                                      "\n1. check stack is empty or not" +
                                      "\n2. check stack is full or not " +
                                      "\n3. Insert data to stack" +
                                      "\n4. peek data from stack" +
                                      "\n5. pop out data from stack" +
                                      "\n6. Find top of stack" +
                                      "\n7. Find Bottom of stack" +
                                      "\n8. Display stack"+
                                      "\n0. quit");

                    int option = Convert.ToInt32(Console.ReadLine());
                    StackUsingArray stack = new StackUsingArray();
                    switch (option)
                    {
                        case 1:
                            bool output = stack.IsEmpty(s);
                            if (output == true)
                            {
                                Console.WriteLine("stack is Empty");
                            }
                            else
                            {
                                Console.WriteLine("stack is not empty");
                            }
                            break;
                        case 2:
                            bool ans = stack.IsFull(s);
                            if (ans == true)
                            {
                                Console.WriteLine("stack is Full");
                            }
                            else
                            {
                                Console.WriteLine("stack is not Full");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter value for insertion ");
                            int value = Convert.ToInt32(Console.ReadLine());
                            stack.Push(s, value);
                            break;
                        case 4:
                            Console.WriteLine("Enter value for index");
                            int ind = Convert.ToInt32(Console.ReadLine());
                            int peek = stack.Peek(s, ind);
                            Console.WriteLine("{0} peek value ", peek);
                            break;
                        case 5:
                            int pop = stack.Pop(s);
                            Console.WriteLine("{0} pop value ", pop);
                            break;
                        case 6:
                            int top = stack.StackTop(s);
                            Console.WriteLine("{0} top value", top);
                            break;
                        case 7:
                            int bottom = stack.stackBottom(s);
                            Console.WriteLine("{0} bottom value", bottom);
                            break;
                        case 8:
                            stack.displayStack(s);
                            break;
                        case 0:
                            StackArrayflag = false;
                            break;



                    }



                }
            }

            else if (val == 2)
            {
                while (stackLinkedlistflag == true)
                {


                    StackUsingLinkedList stack = new StackUsingLinkedList();
                    Console.WriteLine("choose Wisely for Opreation on stack" +
                                      "\n1. check stack is empty or not" +
                                      "\n2. check stack is full or not " +
                                      "\n3. Insert data to stack" +
                                      "\n4. peek data from stack" +
                                      "\n5. pop out data from stack" +
                                      "\n6. Find top of stack" +
                                      "\n7. Find Bottom of stack" +
                                      "\n8. Display stack"+
                                      "\n0. quit");

                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            bool output = stack.IsEmpty();
                            if (output == true)
                            {
                                Console.WriteLine("stack is Empty");
                            }
                            else
                            {
                                Console.WriteLine("stack is not empty");
                            }
                            break;
                        case 2:
                            bool ans = stack.IsFull();
                            if (ans == true)
                            {
                                Console.WriteLine("stack is Full");
                            }
                            else
                            {
                                Console.WriteLine("stack is not Full");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter value for insertion ");
                            int value = Convert.ToInt32(Console.ReadLine());
                            stack.Push(value);
                            break;
                        case 4:
                            Console.WriteLine("Enter value for index");
                            int ind = Convert.ToInt32(Console.ReadLine());
                            int peek = stack.Peek(ind);
                            Console.WriteLine("{0} peek value ", peek);
                            break;
                        case 5:
                            int pop = stack.Pop();
                            Console.WriteLine("{0} pop value ", pop);
                            break;
                        case 6:
                            stack.StackTop();

                            break;
                        case 7:
                            stack.StackBottom();

                            break;
                        case 8:
                            stack.StackTraversal();
                            break;
                        case 0:
                            stackLinkedlistflag = false;
                            break;



                    }
                }



            }

        }

        
    }
}