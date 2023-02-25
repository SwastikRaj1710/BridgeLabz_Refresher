using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    public class Node1
    {
        public string data;
        public Node1 next;

        public Node1(string d, Node1 n)
        {
            data = d;
            next = n;
        }
    }

    internal class LinkedListUtility
    {
        public Node1 head;
        public int size;
        public void InsertFirst(string new_data)
        {
            size++;
            Node1 new_node = new Node1(new_data, null);
            if (head == null)
            {
                head = new_node;
                return;
            }
            else
            {
                new_node.next = head;
                head = new_node;
            }
        }

        public void InsertLast(string new_data)
        {
            size++;
            Node1 new_node = new Node1(new_data,null);
            if (head == null)
            {
                head = new_node;
                return;
            }
            Node1 lastNode = GetLastNode();
            lastNode.next = new_node;
        }

        public Node1 GetLastNode()
        {
            Node1 temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public Node1 GetFirstNode()
        {
            return head;
        }

        public void DeleteNodebyKey(string key)
        {
            size--;
            Node1 temp = head;
            Node1 prev = null;
            if (temp != null && temp.data.Equals(key))
            {
                head = temp.next;
                return;
            }
            while (temp != null && !(temp.data.Equals(key)))
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }

        public bool ContainsNode(string data)
        {
            Node1 temp = head;
            while (temp!= null)
            {
                if (temp.data.Equals(data))
                    return true;
                temp = temp.next;
            }
            return false;
        }

        public int NodeCount()
        {
            return size;
        }

    }
}
