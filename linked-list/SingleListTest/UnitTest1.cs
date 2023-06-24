using System.Numerics;
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
			linkedList.AddLast(1);

			// Act
			string data=linkedList.PrintList();
			// Assert
			Assert.Equal("1 -> Null", data);
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
	}
}