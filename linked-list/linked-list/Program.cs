namespace linked_list
{
	public class Program
	{
		static void Main(string[] args)
		{
			LinkedList List =new LinkedList();	
			List.AddLast(1);
			List.AddLast(2);	
			List.AddLast(3);	
		 string data=	List.PrintList();
			Console.WriteLine(data);
			Console.WriteLine(List.Counter);
			Console.WriteLine(List.Search(3));
			Console.WriteLine(List.Search(2));
			Console.WriteLine(List.Search(4));

			/// Doubly
			DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
			doublyLinkedList.AddLast(1);
			doublyLinkedList.AddLast(2);	
		    doublyLinkedList.AddLast(3);
			Console.WriteLine(doublyLinkedList.Head.Data);//1
			Console.WriteLine(doublyLinkedList.Head.Previous);//null
			Console.WriteLine(doublyLinkedList.Head.Next.Data);//2
			Console.WriteLine(doublyLinkedList.Head.Next.Previous.Data);//1
			


		}
	}
}