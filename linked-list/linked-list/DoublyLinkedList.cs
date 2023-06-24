using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
	internal class DoublyLinkedList
	{
		public DoublyNode Head;
		public DoublyNode Tail;
		public int Counter { set; get; }
		public DoublyLinkedList()
		{

			this.Head = null;
			this.Tail = null;
		}

		public void AddFirst(int data)
		{
			DoublyNode newNode = new DoublyNode(data);

			if (Head == null && Tail == null)
			{
				Head = newNode;
				Tail = newNode;
			}

			else
			{

				newNode.Next = Head;
				Head = newNode;

			}
			Counter++;

		}
		public void AddLast(int data)
		{
			DoublyNode newNode = new DoublyNode(data);

			if (Head == null && Tail == null)
			{
				Head = newNode;
				Tail = newNode;
			}

			else
			{
				newNode.Previous = Tail;
				Tail.Next = newNode;

				Tail = newNode;

			}
			Counter++;

		}
		public string PrintList()
		{
			string Data = "";
			DoublyNode node = Head;
			while (node != null)
			{
				Data += $"{node.Data} -> ";
				node = node.Next;
			}
			Data += "Null";
			return Data;

		}

		public bool Search(int value)
		{

			DoublyNode node = Head;
			while (node != null)
			{
				if (node.Data == value) { return true; }
				node = node.Next;
			}

			return false;

		}
	}
}
