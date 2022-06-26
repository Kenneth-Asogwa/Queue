using System;
using System.Collections.Generic;

namespace GenericQueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queue is a data structure that represents a first-in-first-out (FIFO) algorithm
            Queue<string> myQueue = new Queue<string>();
            //The push() method is use to insert an item into the stack
            myQueue.Enqueue("C#");
            myQueue.Enqueue("Docker");
            myQueue.Enqueue("SQL Server");
            myQueue.Enqueue("JavaScript");

            Console.WriteLine("My queue list...............");
            foreach (string obj in myQueue)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("......................");
            // Calling the Dequeue() method removes an item from the top of the queue
            Console.WriteLine("Popping = {0}", myQueue.Dequeue());
            foreach (string obj in myQueue)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("......................");
            // Peek() method returns an item at the top of the queue but does not remove it from the queue.
            Console.WriteLine("Peeking = {0}", myQueue.Peek());
            foreach (string obj in myQueue)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine(".......................");
            // To print a queue as array create a copy of the queue using ToArray()  method
            Queue<string> myQueueCopy = new Queue<string>(myQueue.ToArray());
            Console.WriteLine("Contents of the first copy");
            foreach (string obj in myQueueCopy)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("......................");
            // Create an array twice the size of the stack and copy the element of the queue
            string[] array = new string[myQueue.Count * 2];
            myQueue.CopyTo(array, myQueue.Count);

            // Create a second queue
            Queue<string> myQueueCopy2 = new Queue<string>(array);
            Console.WriteLine("Contents of the second copy");
            foreach (string obj in myQueueCopy2)
            {
                Console.WriteLine(obj);
            }
            // Call the Contains() method
            Console.WriteLine("Does queue2 contains Java? = {0}", myQueueCopy2.Contains("Java"));

            Console.Read();
        }
    }
}
