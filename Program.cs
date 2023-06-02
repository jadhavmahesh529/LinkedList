using System.Collections.Generic;

namespace LinkedList1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Linkedlist<int> linkedlist = new Linkedlist<int>();
            linkedlist.AddNode(70);
            linkedlist.AddNode(30);
            linkedlist.AddNode(56);
            linkedlist.PrintList();

        }
    }
}