using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int d, Node n)
        {
            data = d;
            next = n;
        }
    }

    internal class QueueUtility
    {
        public Node front, rear;
        public int size;

        public bool isEmpty()
        {
            return front == null;
        }

        public int getSize()
        {
            return size;
        }

        public void enqueue(int data)
        {
            Node node = new Node(data, null);
            if (rear == null)
            {
                front = node;
                rear = node;
            }
            else
            {
                rear.next = node;
                rear = rear.next;
            }
            size++;
        }

        public int dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            Node ptr = front;
            front = ptr.next;
            if (front == null)
            {
                rear = null;
                size--;
            }
            return ptr.data;
        }

        public int peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -999;
            }
            return front.data;
        }

        public void display()
        {
            int sumTotal = 0;
            Console.Write("Available Balance: ");
            if (size == 0)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node temp = front;
            while (temp != rear.next)
            {
                sumTotal+= temp.data;
                temp = temp.next;
            }
            Console.WriteLine(sumTotal);
            Console.WriteLine();
        }
    }
}
