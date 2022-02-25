using System;

namespace LinkedListAnalysis
{
    public class Program
    {
        static void Main()
        {
            SinglyLinkedlist lnklist = new SinglyLinkedlist();
            bool flag = true;
            while(flag == true)
            {
                
                Console.WriteLine("Choose wisely to do action with your linkedlist" +
                                    "\n1. Insert Node  at front " +
                                    "\n2. Insert Node at Last  " +
                                    "\n3. Get Last Node Information " +
                                    "\n4. Display linkedlist " +
                                    "\n5. Delete Last Node " +
                                    "\n6. Delete Node on Given Element " +
                                    "\n7. Delete Node at Given Position " +
                                    "\n8. Delete Whole List. " +
                                    "\n9. Count Length of LinkedList " +
                                    "\n10. Swaping of provide Node data" +
                                    "\n11. InsertNode After given element node"+
                                    "\n12. Sorting by Bubble Sort"+
                                    "\n0. quit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        lnklist.InsertFront();
                        break;
                    case 2:
                        lnklist.InsertLast();
                        break;
                    case 3:
                        lnklist.GetLastNode();
                        break;
                    case 4:
                        lnklist.display();
                        break;
                    case 5:
                        lnklist.DeleteLastNode();
                        break;
                    case 6:
                        lnklist.DeleteNodeOnKey();
                        break;
                    case 7:
                        lnklist.DeleteAtPosition();
                        break;
                    case 8:
                        lnklist.DeleteWholelist();
                        break;
                    case 9:
                        lnklist.CountLength();
                        break;
                    case 10:
                        lnklist.SwapNode();
                        break;
                    case 11:
                        lnklist.InsertAfter();
                        break;
                    case 12:
                        lnklist.BubbleSort();
                        break;
                    case 0:
                        flag = false;
                        break;
                }
                
            }
        }
    }
}
