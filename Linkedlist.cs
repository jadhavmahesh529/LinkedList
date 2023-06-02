using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{
    internal class Linkedlist<T>
    {
        public Node<T> head;
        public Node<T> tail;
        public void AddNode(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }
        public void Append(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
        }
        public void PrintList()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
