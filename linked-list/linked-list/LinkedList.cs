using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

		/*public LinkedList zipLists(LinkedList list1, LinkedList list2)
		{
			LinkedList finalZip = new LinkedList();	
			int list1Length = list1.Counter;
			int list2Length = list2.Counter;
			int LoopLingth = 0;
			if(list1Length > list2Length) { LoopLingth = list1Length; }
			else { LoopLingth = list2Length; }
			Node node1 = list1.Head;
			Node node2 = list2.Head;

			for (int i = 0; i < LoopLingth; i++)
			{

				if (list1Length != 0)
				{
					//Node newNode = new Node(node1.Data);
					finalZip.AddLast(node1.Data);
					list1Length--;
					if (node1.Next != null)
					{
						node1 = node1.Next;
					}
				}
				

				if (list2Length != 0)
				{
					//Node newNode = new Node(node2.Data);
					//finalZip.Tail.Next = newNode;
					//finalZip.Tail = newNode;
					finalZip.AddLast(node2.Data);
					list2Length--;
					if (node2.Next != null)
					{
						node2 = node2.Next;
					}

				}

			}

			return finalZip;
		
		}*/
	
	
	}
} 
