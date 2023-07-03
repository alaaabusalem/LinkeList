using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
	public class LinkedList
	{
		public Node Head;
		public Node Tail;
		public int Counter { set; get; }
		public LinkedList() {

			this.Head = null;
			this.Tail = null;
		}

		public void AddFirst(int data) {
			Node newNode = new Node(data);

			if (Head == null && Tail == null)
			{
				Head = newNode;
				Tail = newNode;
			}

			else {

				newNode.Next = Head;
				Head = newNode;

			}
			Counter++;

		}

		
		public string PrintList()
		{
			string Data = "";
			Node node = Head;
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

			Node node = Head;
			while (node != null)
			{
				if (node.Data == value) { return true; }
				node = node.Next;
			}

			return false;

		}

		
		///////////// CC6 
	
		
		// add to the End of the list
		public void AddLast(int data)
		{
			Node newNode = new Node(data);

			if (Head == null && Tail == null)
			{
				Head = newNode;
				Tail = newNode;
			}

			else
			{
				Tail.Next = newNode;
				Tail = newNode;

			}
			Counter++;

		}

		public void InsertBefore(int newvalue, int valuetosearch)
		{
			Node newNode = new Node(newvalue);

			if (Head.Data == valuetosearch)
			{
				newNode.Next = Head;
				Head = newNode;
			}

			else {
				Node node = Head;
				while (node != null)
				{
					if (node.Next.Data == valuetosearch) {

						newNode.Next = node.Next;
						node.Next = newNode;
						break;
						
					}
					node = node.Next;

				}
			}

		}



		public void InsertAfter(int newvalue, int valuetosearch)
		{
			Node newNode = new Node(newvalue);

			if (Head.Data == valuetosearch)
			{
				newNode.Next= Head.Next;
				Head.Next = newNode;	
			}

			else
			{
				Node node = Head.Next;
				while (node != null)
				{
					if (node.Data == valuetosearch)
					{

						newNode.Next=node.Next;
						node.Next = newNode;
						break;
						
					}
					node = node.Next;
				}
			}

		}
		
		//CC7
		public int kthFromEnd(int index)
		{

			if (index >= Counter) { throw new Exception(); };
			if (Head == null)
			{
				return -1;
			}
			if (index < 0) { return -1; }	
		//	if (index == Counter - 1) { return Head.Data; }
			Node node= Head;
			for(int i=1; i<Counter-index; i++) { 
			 node = node.Next;
			
			}
			return node.Data;
		}


	}
} 
