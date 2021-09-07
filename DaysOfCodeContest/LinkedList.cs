using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
    class LinkedList
    {
        public static Node3 insert(Node3 head, int data)
        {
            Node3 new_node = new Node3(data);
            if (head == null)
            {
                head = new_node;
                return head;
            }
            Node3 temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            Node3 last_node = temp;
            last_node.next = new_node;
            return head;
        }
        public static void display(Node3 head)
        {
            Node3 start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }
    class Node3
    {
        public int data;
        public Node3 next;
        public Node3(int d)
        {
            data = d;
            next = null;
        }

    }
}
