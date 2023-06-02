﻿using System;
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
        public void Pop()
        {
            if (head != null)
            {
                head = head.next;
            }
        }
        public void PopLast()
        {
            if (head == null)
            {

                return;
            }

            if (head == tail)
            {

                head = null;
                tail = null;
                return;
            }

            Node<T> current = head;
            while (current.next != tail)
            {
                current = current.next;
            }


            tail = current;
            tail.next = null;
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
