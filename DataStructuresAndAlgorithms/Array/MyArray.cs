using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.MyArray
{
    public class MyArray
    {
        private int[] _items;
        private int _count;
        public MyArray(int length)
        {
            _items = new int[length];
            _count = 0;
        }
        public void Print()
        {
            //Action<int> action = new Action<int>(DataUtils.Utils.Print);
            //Array.ForEach(_items, action);
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_items[i]);
            }
        }
       
    }
}
