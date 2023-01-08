using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3.Items
{
	public class Employee : OnID 
	{
		
		public String FirstName { get; set; }
		public String LastName { get; set; }
		public override string ToString()
		{
			return ID + "|" + FirstName + " " + LastName;	
		}
	}
}
