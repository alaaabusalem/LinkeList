using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
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
