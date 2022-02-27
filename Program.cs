using System;

namespace QueueAnalysisUsingLinkedList
{
    public class Program
    {
        static void Main()
        {
            Node front = null;
            Node rear = null;
            QueueLinkedList queue = new QueueLinkedList();
            queue.Enqueue(23);
            queue.Enqueue(363);
            Console.WriteLine("Element dequeue is : {0} ", queue.dequeue());
            queue.QueueTraversal();
        }
    }
}
