using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Queue
{
    public class ArrayQueue
    {
        // Enqueue
        // Dequeue
        // Peek
        // IsEmpty
        // IsFull

        // [10, 20, 30, 40, 0]
        //   F           R
        // F=0
        // R=3

        // [10, 20, 30, 40, 0]
        //      F           R
        // F=1
        // R=4

        private int[] _items = new int[5];
        private int _rear;
        private int _front;
        private int _count;
        public ArrayQueue(int capacity)
        {
            _items = new int[capacity];
        }

        public void Enqueue(int item)
        {
            if (_count == _items.Length) 
                throw new ArgumentOutOfRangeException();
            
            _items[_rear] = item;
            _rear = (_rear + 1) % _items.Length;
            _count++;
        }
        public int Dequeue()
        {
            var item = _items[_front];
            _items[_front] = 0;
            _front = (_front + 1) % _items.Length;
            _count--;
            return item;
        }
        public override string ToString()
        {
            return DataUtils.Utils.Array2String(_items);
        }



    }
}
