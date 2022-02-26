using System;

namespace QueueAnalysis
{
    public class Program
    {
        static void Main()
        {
            Queue q = new Queue();
            q.size = 100;
            q.front = -1;
            q.rear = -1;
            q.arr = new int[q.size];

            QueueImplementationonArray queue = new QueueImplementationonArray();
            queue.enqueue(q, 345);
            queue.enqueue(q, 56);
            queue.QueueTraversal(q);
        }
    }
}
