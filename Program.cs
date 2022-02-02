using System;

namespace LinkedListApproach
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Approach ");
            SinglyLinkedlist sl = new SinglyLinkedlist();
            sl.InsertFront(5);
            sl.InsertLast(7);
            sl.InsertLast(10);
            sl.InsertLast(17);
            sl.InsertLast(25626);
            sl.InsertLast(2452);
            sl.InsertLast(41252);


            sl.SwapNode(17, 41252);

           // sl.display();
           //  Console.WriteLine("list deleted ");
           //  sl.DeleteWholelist();
           // Console.WriteLine("list deleted");
            sl.display();
        }
    }
}
