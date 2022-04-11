using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Linked_List
{
    public static class Demo1
    {
        private static LinkedList<int> list1 = new LinkedList<int>();
        public static void Demo()
        {
            list1.AddLast(10);
            list1.AddLast(20);
            list1.AddLast(30);
            list1.AddFirst(5);
            
            Console.WriteLine(DataUtils.Utils.Array2String(list1));
            Console.WriteLine(DataUtils.Utils.Array2String(list1.ToArray()));
            Console.WriteLine(list1.Count);
            Console.WriteLine(list1.Contains(20));
        }

    }
}
