using System;

namespace QueueAnalysis
{
    /// <summary>
    /// A Queue in C# represents a first-in, first-out (FIFO) collection of objects.
    /// An example of a queue is a line of people waiting.
    /// in queue we have two ends at first end insertion occur and other end deletion occur
    /// dequeue always occur at front end and enqueue always occur at rear end
    /// </summary>
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose wisely for Queue " +
                              "1. Single queue" +
                              "2. Circular queue");
            int val = Convert.ToInt32(Console.ReadLine());
            bool queueFlag = true;
            bool circularqueueFlag = true;




            if (val == 1)
            {
                Queue q = new Queue();
                QueueImplementationonArray queue = new QueueImplementationonArray();

                Console.WriteLine("Enter size of your Array for queue");
                int size = Convert.ToInt32(Console.ReadLine());
                q.size = size;
                q.front = -1;
                q.rear = -1;
                q.arr = new int[q.size];
                while (queueFlag == true)
                {
                    Console.WriteLine("Choose wisely for opreation on queue" +
                                      "\n1. check weather queue is full or not" +
                                      "\n2. check weather queue is Empty or not" +
                                      "\n3. To insert data from queue" +
                                      "\n4. To pop out data from queue" +
                                      "\n5. Traversal through queue" +
                                      "\n0. quit");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            if (queue.IsFull(q))
                            {
                                Console.WriteLine("queue is Full");
                            }
                            else
                            {
                                Console.WriteLine("queue is not full");
                            }
                            break;
                        case 2:
                            if (queue.IsEmpty(q))
                            {
                                Console.WriteLine("queue is Empty");
                            }
                            else
                            {
                                Console.WriteLine("queue is not Empty");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter data which you want to insert");
                            int input = Convert.ToInt32(Console.ReadLine());
                            queue.enqueue(q, input);
                            break;
                        case 4:
                            Console.WriteLine("Element pop out is : {0} ", queue.dequeue(q));
                            break;
                        case 5:
                            queue.QueueTraversal(q);
                            break;
                        case 0:
                            queueFlag = false;
                            break;






                    }

                }

            }

            if (val == 2)
            {
                CircularQueueWithArray queue = new CircularQueueWithArray();
                CircularQueue cq = new CircularQueue();
                cq.size = 10;
                cq.front = 0;
                cq.rear = 0;
                cq.arr = new int[cq.size];

                while (circularqueueFlag == true)
                {
                    Console.WriteLine("Choose wisely for opreation on queue" +
                                      "\n1. check weather queue is full or not" +
                                      "\n2. check weather queue is Empty or not" +
                                      "\n3. To insert data from queue" +
                                      "\n4. To pop out data from queue" +
                                      "\n5. Traversal through queue" +
                                      "\n0. quit");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            if (queue.IsFull(cq))
                            {
                                Console.WriteLine("queue is Full");
                            }
                            else
                            {
                                Console.WriteLine("queue is not full");
                            }
                            break;
                        case 2:
                            if (queue.IsEmpty(cq))
                            {
                                Console.WriteLine("queue is Empty");
                            }
                            else
                            {
                                Console.WriteLine("queue is not Empty");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter data which you want to insert");
                            int input = Convert.ToInt32(Console.ReadLine());
                            queue.enqueue(cq, input);
                            break;
                        case 4:
                            Console.WriteLine("Element pop out is : {0} ", queue.dequeue(cq));
                            break;
                        case 5:
                            queue.QueueTraversal(cq);
                            break;
                        case 0:
                            circularqueueFlag = false;
                            break;






                    }

                }
            }








        }
    }
}
