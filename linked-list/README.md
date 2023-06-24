# data-structures-and-algorithms

## Linked List
This is My console App For Singly and Doubly Linked test implementation. each type ontain a methods for adding to first and last of the Linked List, seraching for an element if it exist, print the content.


## Singly Linked List

```C#

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

    public class Node
	{
		public int Data { set; get; }
		public Node Next { set; get; }	
		public Node(int data) { 
		
		this.Data = data;
			this.Next = null;
		
		}
	}
}
```

## Doubly Linked List

```C#
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
    	public class DoublyNode
	{
     public int Data { set;get; }
	public DoublyNode Previous { set; get; }
		public DoublyNode Next { set; get; }
		public DoublyNode(int data) { 
		
		 this.Data = data;
			Previous = null;
			Next = null;
		}	
	}
}

```

