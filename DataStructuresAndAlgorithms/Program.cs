using DataStructuresAndAlgorithms.MyArray;
using DataStructuresAndAlgorithms.DataUtils;
using System.Collections;
using DataStructuresAndAlgorithms.Linked_List.DemoLL;

//DataStructuresAndAlgorithms.ArraysDemo1.ArraysExample();
//ArrayDemo();
//ArrayDynamicArray();

//LinkedListDemo1();
MyLinkedList();

void ArrayDemo()
{
    var numbers = new MyArray(3);
    try
    {
        numbers.Insert(10);
        numbers.Insert(20);
        numbers.Insert(60);
        numbers.Insert(40);
        //numbers.Print();

        //Console.WriteLine("-----"); // Environment.NewLine);
        //numbers.RemoveAt(-1);
        //Console.WriteLine(numbers.IndexOf(20));
        //numbers.Print();
        //Console.WriteLine(numbers.LargestNumber());

        //var reverse = numbers.Reverse();
        //Utils.PrintString(reverse);

        //int[] newArr = { 10, 70, 60, 20 };
        //var intersect = numbers.CommonItems(newArr);
        //Utils.PrintString(intersect);

        numbers.InsertAt(4, 100);
        Console.WriteLine(numbers.IndexOf(100));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"{ex.Message} {ex.StackTrace}");
    }
}
void ArrayDynamicArray()
{
    ArrayList list = new ArrayList();
    list.Add(10);
    list.Add(20);
    list.Add(30);
    list.Remove(30);
    //string.Join(",", list);
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}

void LinkedListDemo1()
{
    DataStructuresAndAlgorithms.Linked_List.Demo1.Demo();
}
void MyLinkedList()
{
    var list = new LinkedList();
    //Console.WriteLine(list.Size());
    list.AddLast(10);
    list.AddLast(20);
    list.AddLast(30);
    //Console.WriteLine(list.Size());

    //list.AddFirst(5);
    //list.AddFirst(15);
    //Console.WriteLine(list.Size());

    //Console.WriteLine(list.IndexOf(10));
    //Console.WriteLine(list.IndexOf(30));
    //Console.WriteLine(list.IndexOf(400));

    //Console.WriteLine(list.Contains(400));
    //Console.WriteLine(list.Contains(10));

    //Console.WriteLine(list.Size());
    //list.RemoveFirst();
    //Console.WriteLine(list.Size());

    //Console.WriteLine(list.Size());
    //list.RemoveLast();
    //Console.WriteLine(list.Size());

    //convert liked list to an array:
    //Console.WriteLine(Utils.Array2String(list.ToArray()));

    //list.Reverse();
    //Console.WriteLine(Utils.Array2String(list.ToArray()));


    //list.AddLast(40);
    //list.AddLast(50);
    //Console.WriteLine(list.GetKthFromTheEnd(1));
    //Console.WriteLine(list.GetKthFromTheEnd(2));
    //Console.WriteLine(list.GetKthFromTheEnd(3));
    //Console.WriteLine(list.GetKthFromTheEnd(0));
    //Console.WriteLine(list.GetKthFromTheEnd(6));

    //list.PrintMiddle();
    //list.AddLast(60);
    //list.PrintMiddle();

    var listWithLoop = list.CreateWithLoop();
    Console.WriteLine(listWithLoop.HasLoop());

}
