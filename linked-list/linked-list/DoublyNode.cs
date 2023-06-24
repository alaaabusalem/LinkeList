using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
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
