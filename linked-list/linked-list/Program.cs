namespace linked_list
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Singly");
			Console.WriteLine("");
			LinkedList List =new LinkedList();	
			List.AddFirst(1);
			List.AddFirst(2);	
			List.AddFirst(3);	
		 string data=	List.PrintList();
			Console.WriteLine(data);
			Console.WriteLine(List.Counter);
			Console.WriteLine(List.Search(3));
			Console.WriteLine(List.Search(2));
			Console.WriteLine(List.Search(4));

			Console.WriteLine("test");
			Console.WriteLine(List.kthFromEnd(0));//3
			Console.WriteLine(List.kthFromEnd(1));//2
			Console.WriteLine(List.kthFromEnd(2));//1

			Console.WriteLine("test");



			/// Doubly
			Console.WriteLine("");
			Console.WriteLine("Doubly");
			Console.WriteLine(" ");
			DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
			doublyLinkedList.AddLast(1);
			doublyLinkedList.AddLast(2);	
		    doublyLinkedList.AddLast(3);
			Console.WriteLine(doublyLinkedList.Head.Data);//1
			Console.WriteLine(doublyLinkedList.Head.Previous);//null
			Console.WriteLine(doublyLinkedList.Head.Next.Data);//2
			Console.WriteLine(doublyLinkedList.Head.Next.Previous.Data);//1

			/////////// CC6
			///
			/*Console.WriteLine("");
			Console.WriteLine("CC6 Singly");
			Console.WriteLine("");
			LinkedList List2 = new LinkedList();
			List2.AddLast(1);
			List2.AddLast(2);
			List2.AddLast(3);

			string data2 = List2.PrintList();
			Console.WriteLine(data2);
			List2.InsertBefore(5, 2);
			data2 = List2.PrintList();
			Console.WriteLine(data2);
			List2.InsertAfter(10, 2);
			data2 = List2.PrintList();
			Console.WriteLine(data2);*/


			///// code challenge 8
			LinkedList List1 = new LinkedList();
			List1.AddLast(1);
			List1.AddLast(3);
			List1.AddLast(2);
			LinkedList List2 = new LinkedList();
			List2.AddLast(5);
			List2.AddLast(9);
			List2.AddLast(4);

			LinkedList final = zipLists(List1, List2);
			//final=List1.zipLists(List1, List2);
			Console.WriteLine("CC8");	
			string printFinal=final.PrintList();
			Console.WriteLine(printFinal);
		}

		public static LinkedList zipLists(LinkedList list1, LinkedList list2)
		{
			LinkedList finalZip = new LinkedList();
			int list1Length = list1.Counter;
			int list2Length = list2.Counter;
			int LoopLingth = 0;
			if (list1Length > list2Length) { LoopLingth = list1Length; }
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

		}
	}
}