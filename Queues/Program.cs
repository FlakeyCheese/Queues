using System;

namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] simpleQueue = new int[10]; //an array with space for 10 items
            int front = 0;
            int rear =-1;
            dequeue(simpleQueue,ref front, rear);
            enqueue(simpleQueue, ref rear, 12);
            enqueue(simpleQueue, ref rear, 13);
            enqueue(simpleQueue, ref rear, 14);
            enqueue(simpleQueue, ref rear, 15);
            printQueue(simpleQueue, front, rear);
           Console.WriteLine( dequeue(simpleQueue, ref front, rear));//remove first item and print it out. 12!
            Console.WriteLine();//force a gap
            printQueue(simpleQueue, front, rear);
            dequeue(simpleQueue, ref front, rear);
            dequeue(simpleQueue,ref front, rear);
            printQueue(simpleQueue, front, rear);
            dequeue(simpleQueue, ref front, rear);//remove the last item
            Console.WriteLine(dequeue(simpleQueue, ref front, rear));// queue's empty

            enqueue(simpleQueue,ref rear, 1);
            enqueue(simpleQueue,ref rear, 2);
            enqueue(simpleQueue,ref rear, 3);
            enqueue(simpleQueue,ref rear, 4);
            enqueue(simpleQueue,ref rear, 5);   
            enqueue(simpleQueue,ref rear, 6);   
            enqueue(simpleQueue,ref rear, 7);
            enqueue(simpleQueue,ref rear, 8);   
            printQueue(simpleQueue, front, rear);
        }
        public static bool isEmpty(int front , int rear)
        {
            if (front  > rear)
            { return true; }
            else
            { return false; }
        }
        public static bool isFull(int rear)
        {
            if (rear == 9)
            { return true; }
            else
            { return false; }
        }
        public static void enqueue(int[] queue, ref int rear, int data)
        {
            if (isFull(rear))
                { Console.WriteLine("The queue is full"); }
            else
            { rear++;
                queue[rear] = data;
            }
        }
        public static int dequeue(int[] queue, ref int front, int rear)
        {
            if (isEmpty(front, rear))
            { Console.WriteLine("There is nothing to dequeue - the queue is empty");
                return -1;
            }
            else
            { front++;
                return queue[front - 1];
            }
        }
        public static void printQueue( int[] queue, int front, int rear)
        {
            Console.WriteLine("Here is the queue");
            for (int i= front;i<=rear ;i++)
            { Console.WriteLine(queue[i]); }
            Console.WriteLine();
        }
    }
}
