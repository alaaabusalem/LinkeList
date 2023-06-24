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
		
		if(Head==null && Tail == null)
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
				Tail= newNode;	

			}
			Counter++;

		}
		public string PrintList()
		{
			string Data = "";
			Node node =Head;
			while (node != null)
			{
				Data += $"{node.Data} -> ";
				node= node.Next;	
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

	}
}
