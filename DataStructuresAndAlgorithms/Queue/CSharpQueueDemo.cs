﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Queue
{
    public static class CSharpQueueDemo
    {
        public static void Demo()
        {
            Queue<int> q = new Queue<int>();

            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Dequeue();

            Console.WriteLine(DataStructuresAndAlgorithms.DataUtils.Utils.Array2String(q.ToArray()));
        }
        public static void Reverse(Queue<int> queue)
        {
            // add
            // remove
            // isEmpty
            // Q [10,20,30]
            // S [10, 20, 30]
            Stack<int> stack = new Stack<int>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
            Console.WriteLine(DataStructuresAndAlgorithms.DataUtils.Utils.Array2String(queue.ToArray()));
        }

        public static void ArrayQueueDemo()
        {
            var queue = new ArrayQueue(5);
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            //Console.WriteLine(queue.ToString());
            var front = queue.Dequeue();
            //Console.WriteLine(front);
            //Console.WriteLine(queue.ToString());

            front = queue.Dequeue();
            //Console.WriteLine(front);
            //Console.WriteLine(queue.ToString());

            queue.Enqueue(40);
            queue.Enqueue(50);
            Console.WriteLine(queue.ToString());

            queue.Enqueue(60);
            Console.WriteLine(queue.ToString());

            queue.Enqueue(70);
            Console.WriteLine(queue.ToString());

            queue.Dequeue();
            Console.WriteLine(queue.ToString());

            queue.Enqueue(80);
            Console.WriteLine(queue.ToString());

        }
    }
}
