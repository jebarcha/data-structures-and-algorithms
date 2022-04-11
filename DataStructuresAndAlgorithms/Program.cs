using DataStructuresAndAlgorithms.MyArray;
using DataStructuresAndAlgorithms.DataUtils;
using System.Collections;

//DataStructuresAndAlgorithms.ArraysDemo1.ArraysExample();
//ArrayDemo();
//ArrayDynamicArray();

LinkedListDemo1();

void ArrayDemo()
{
    var numbers = new MyArray(3);
    try
    {
        numbers.Insert(10);
        numbers.Insert(20);
        numbers.Insert(60);
        numbers.Insert(40);
        //numbers.RemoveAt(4);
        //Console.WriteLine(numbers.IndexOf(30));
        //numbers.Print();
        //Console.WriteLine(numbers.LargestNumber());

        //var reverse = numbers.Reverse();
        //Utils.PrintString(reverse);

        //int[] newArr = { 10, 70, 60, 20 };
        //var intersect = numbers.CommonItems(newArr);
        //Utils.PrintString(intersect);

        numbers.InsertAt(5, 100);
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
