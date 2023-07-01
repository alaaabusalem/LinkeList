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
			Console.WriteLine("");
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
			Console.WriteLine(data2);
		

		}
	}
}