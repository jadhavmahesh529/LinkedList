using System.Collections.Generic;

namespace LinkedList1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Linkedlist<int> linkedlist = new Linkedlist<int>();
            //linkedlist.AddNode(70);
            //linkedlist.AddNode(30);
            //linkedlist.AddNode(56);

            //linkedlist.Append(56);
            //linkedlist.Append(30);
            //linkedlist.Append(70);
            //linkedlist.PrintList();

            //linkedlist.AddNode(70);
            //linkedlist.AddNode(30);
            //linkedlist.AddNode(56);

            //linkedlist.PrintList();
            //linkedlist.PopLast();
            //linkedlist.Pop();
            //linkedlist.Insert(56, 70, 30);
            //linkedlist.PrintList();
            linkedlist.AddNode(70);
            linkedlist.AddNode(30);
            linkedlist.AddNode(56);
            linkedlist.PrintList();
            linkedlist.PopLast();
          
            linkedlist.PrintList();
            Console.WriteLine(linkedlist.Search(30));
            int valueToFind = 30;
            int valueToInsert = 40;
            linkedlist.InsertAfter(valueToFind, valueToInsert);
            linkedlist.PrintList();

        }
       
    }
}