using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;
using linked_list;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace SingleListTest
{
	public class UnitTest1
	{
		[Fact]
		void CreatLinkedList()
		{
			// Arrange
		LinkedList linkedList = new LinkedList();
			
			// Act
			
			// Assert
			Assert.Equal(0, linkedList.Counter);
		}

		[Fact]
		void TestAddFirst()
		{
			// Arrange
			LinkedList linkedList = new LinkedList();
			linkedList.AddFirst(1);
			linkedList.AddFirst(2);

			// Act
			string data=linkedList.PrintList();
			// Assert
			Assert.Equal("2 -> 1 -> Null", data);
		}

		[Fact]
		void TestHead()
		{
			// Arrange
			LinkedList linkedList = new LinkedList();
			linkedList.AddLast(1);
			linkedList.AddLast(2);
			linkedList.AddLast(3);

			// Act
			int head = linkedList.Head.Data;
			// Assert
			Assert.Equal(1, head);
		}
		[Fact]
		void TestSearchTrue()
		{
			// Arrange
			LinkedList linkedList = new LinkedList();
			linkedList.AddLast(1);
			linkedList.AddLast(2);
			linkedList.AddLast(3);

			// Act
			bool search = linkedList.Search(2);
			// Assert
			Assert.Equal(true, search);
		}
		[Fact]
		void TestSearchFalse()
		{
			// Arrange
			LinkedList linkedList = new LinkedList();
			linkedList.AddLast(1);
			linkedList.AddLast(2);
			linkedList.AddLast(3);

			// Act
			bool search = linkedList.Search(4);
			// Assert
			Assert.Equal(false, search);
		}

		[Fact]
		void TestPrint()
		{
			// Arrange
			LinkedList linkedList = new LinkedList();
			linkedList.AddFirst(1);
			linkedList.AddFirst(2);
			linkedList.AddFirst(3);

			// Act
			string data = linkedList.PrintList();
			// Assert
			Assert.Equal("3 -> 2 -> 1 -> Null", data);
		}


		//CC6
/// <summary>
/// CC6
/// </summary>

		[Fact]
		void TestAddLast()
		{
			// Can successfully add a node to the end of the linked list
			//Can successfully add multiple nodes to the end of a linked list
			// Arrange
			LinkedList linkedList = new LinkedList();
			linkedList.AddLast(1);
			linkedList.AddLast(2);

			// Act
			string data = linkedList.PrintList();
			// Assert
			Assert.Equal("1 -> 2 -> Null", data);
		}

		[Fact]
		void TestInsertBefore()
		{
			// Can successfully insert a node before a node located i the middle of a linked list
			//Can successfully insert a node before the first node of a linked list

			// Arrange
			LinkedList linkedList = new LinkedList();
			linkedList.AddLast(1);
			linkedList.AddLast(2);
			linkedList.InsertBefore(4, 2);
			linkedList.InsertBefore(5, 1);

			// Act
			string data = linkedList.PrintList();
			// Assert
			Assert.Equal("5 -> 1 -> 4 -> 2 -> Null", data);
		}

		[Fact]
		void TestInsertAfter()
		{
			// Can successfully insert after a node in the middle of the linked list
			//Can successfully insert a node after the last node of the linked list

			// Arrange
			LinkedList linkedList = new LinkedList();
			linkedList.AddLast(1);
			linkedList.AddLast(2);
			linkedList.AddLast(3);
			linkedList.InsertAfter(5, 3);
			linkedList.InsertAfter(8, 5);
			linkedList.InsertAfter(10, 8);

			// Act
			string data = linkedList.PrintList();
			// Assert
			Assert.Equal("1 -> 2 -> 3 -> 5 -> 8 -> 10 -> Null", data);
		}

		// cc7

		[Fact]
		void TestkthFromEnd()
		{
			
			// Arrange
			LinkedList linkedList = new LinkedList();
			linkedList.AddFirst(1);
			linkedList.AddFirst(2);
			linkedList.AddFirst(3);
			linkedList.AddFirst(4);

			// Act
			int data = linkedList.kthFromEnd(2);
			// Assert
			Assert.Equal(3, data);
		}

		[Fact]
		void TestkthSizeOne()
		{

			// Arrange
			LinkedList linkedList = new LinkedList();
			linkedList.AddFirst(1);
			

			// Act
			int data = linkedList.kthFromEnd(0);
			// Assert
			Assert.Equal(1, data);
		}
		[Fact]
		void TestkthFromEndKEqualLength()
		{
			
			// Arrange
			LinkedList linkedList = new LinkedList();
			linkedList.AddFirst(1);
			linkedList.AddFirst(2);
			linkedList.AddFirst(3);
			linkedList.AddFirst(4);

			// Act
			int data = linkedList.kthFromEnd(3);
			// Assert
			Assert.Equal(4, data);
		}

		[Fact]	
		void TestkthFromEndKLessThanZero()
		{
			
			// Arrange
			LinkedList linkedList = new LinkedList();
			linkedList.AddFirst(1);
			linkedList.AddFirst(2);
			linkedList.AddFirst(3);
			linkedList.AddFirst(4);

			// Act
			int data = linkedList.kthFromEnd(-5);
			// Assert
			Assert.Equal(-1, data) ;
			
		}

	}
}