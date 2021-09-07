using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeContest
{
	class Node
	{
		public int data;
		public Node next;
		public Node(int d)
		{
			data = d;
			next = null;
		}
	}
	class MoreLinkedLists
	{
		public static Node removeDuplicates(Node head)
		{
			Node startD = head;
			Node next_node;
			if (startD == null)
			{
				return head;
			}
			while (startD.next != null)
			{
				if (startD.data == startD.next.data)
				{
					next_node = startD.next.next;
					//startD.next = null;
					startD.next = next_node;
				}
				else 
				{
					startD = startD.next;
				}
			}
			return head;
		}

		public static Node insert(Node head, int data)
		{
			Node p = new Node(data);
			if (head == null)
				head = p;
			else if (head.next == null)
				head.next = p;
			else
			{
				Node start = head;
				while (start.next != null)
					start = start.next;
				start.next = p;

			}
			return head;
		}
		public static void display(Node head)
		{
			Node start = head;
			while (start != null)
			{
				Console.Write(start.data + " ");
				start = start.next;
			}
		}
	}
}
